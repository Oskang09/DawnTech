using CSharpOskaAPI;
using NCalc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawnTech
{
    public enum SocsoType
    {
        EMPLOYEE,
        BOSS
    }
    public enum EPFType
    {
        EMPLOYEE,
        BOSS
    }

    public class Employee : IJsonObject<Employee>
    {
        public Employee() : base("employee")
        {

        }


        public Employee(int year, int month) : base("employee")
        {
            this.year = year;
            this.month = month;
        }

        public Employee setParameters(int year, int month)
        {
            this.year = year;
            this.month = month;
            return this;
        }
        [JsonIgnore] private int year { get; set; }
        [JsonIgnore] private int month { get; set; }

        // EmployeeData
        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool isPartTime { get; set; }
        public LeaveData LeaveData { get; set; }
        public string UID { get; set; }
        public string Name { get; set; }
        public string DEPT { get; set; }
        public int Age { get; set; }

        public double Basic { get; set; }

        public bool useEpf { get; set; }

        public bool useSocso { get; set; }

        public bool useEIS { get; set; }

        public string NRIC { get; set; }

        public string BankAcc { get; set; }

        public string BankName { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime? ConfirmDate { get; set; }
       
        [JsonIgnore] public WorkData getWorkData => new WorkData().LoadJson($"{year}-{month}");
        [JsonIgnore] public WorkTime getWorkTime => getWorkData.EMPLOYEES[UID];
       
        public double cLate()
        {
            var exp = new Expression(DataManager.SETTINGS["late"]);
            exp.Parameters["times"] = getWorkTime.Late;
            exp.Parameters["basic"] = Basic;
            exp.Parameters["working_day"] = getWorkData.Working_Day;
            return !isPartTime ? Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero) : 0;
        }
        public double cLeave()
        {
            var exp = new Expression(DataManager.SETTINGS["leave"]);
            exp.Parameters["day"] = LeaveData.leaves.Sum(x => x.Item1.Year == year && x.Item1.Month == month && x.Item5 == LeaveType.UNPAID_LEAVE ? 1 : 0F);
            exp.Parameters["basic"] = Basic;
            exp.Parameters["working_day"] = getWorkData.Working_Day;
            return !isPartTime ? Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero) : 0;
        }

        public double cTotalOT()
        {
            return cOvertime() + cHolidayOT();
        }
        public double cOvertime()
        {
            if (!isPartTime)
            {
                var exp = new Expression(DataManager.SETTINGS["overtime"]);
                exp.Parameters["hour"] = Convert.ToInt32(getWorkTime.Overtime / 60);
                exp.Parameters["basic"] = Basic;
                exp.Parameters["working_day"] = getWorkData.Working_Day;
                return Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero);
            }
            else
            {
                var exp = new Expression(DataManager.SETTINGS["part_ot"]);
                exp.Parameters["basic"] = Basic;
                exp.Parameters["hour"] = Convert.ToInt32(getWorkTime.Overtime / 60);
                return Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero);
            }
        }
        public double cHolidayOT()
        {
            if (!isPartTime)
            {
                var exp = new Expression(DataManager.SETTINGS["holiday"]);
                exp.Parameters["hour"] = Convert.ToInt32(getWorkTime.HolidayOT / 60);
                exp.Parameters["basic"] = Basic;
                exp.Parameters["working_day"] = getWorkData.Working_Day;
                return Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero);
            }
            else
            {
                var exp = new Expression(DataManager.SETTINGS["part_holiday"]);
                exp.Parameters["basic"] = Basic;
                exp.Parameters["hour"] = Convert.ToInt32(getWorkTime.HolidayOT / 60);
                return Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero);
            }
        }

        public double cEPF(EPFType epf)
        {
            return !isPartTime && useEpf ?
                new CALC(cGrossPay()).cEPF(epf) :
                0;
        }

        public double cSocso(SocsoType st)
        {
            return !isPartTime && useSocso ? 
                new CALC(cGrossPay()).cSocso(st) : 
                0;
        }

        public double cEIS()
        {
            return !isPartTime && useEIS ?
                new CALC(cGrossPay()).cEIS() : 
                0;
        }

        public double cGrossPay()
        {
            if (!isPartTime)
            {
                return Math.Round(Basic + cTotalOT() - cLeave(), 2);
            }
            else
            {
                var exp = new Expression(DataManager.SETTINGS["part_normal"]);
                exp.Parameters["basic"] = Basic;
                exp.Parameters["hour"] = Convert.ToInt32(getWorkTime.Worked / 60);
                return Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero) + cTotalOT();
            }
        }

        public double cTotal(SocsoType st, EPFType epf)
        {
            return Math.Round(cGrossPay() - cEPF(epf) - cEIS() - cSocso(st) - cPBC(), 1, MidpointRounding.AwayFromZero);
        }

        public double cNetPay(SocsoType st, EPFType epf)
        {
            return Math.Round(cTotal(st, epf) + cAllowance() - cLate(), 1, MidpointRounding.AwayFromZero);
        }

        public float cMedicalMonth()
        {
            return LeaveData.leaves.Sum(x => x.Item1.Year == year && x.Item1.Month == month ? x.Item3 : 0F);
        }

        public float cMedicalYear()
        {
            return float.Parse(DataManager.SETTINGS["medical_fee_per_year"]) - LeaveData.leaves.Sum(x => x.Item1.Year == year && x.Item5 == LeaveType.MEDICAL_LEAVE ? x.Item3 : 0F);
        }

        public int cMedicalLeave()
        {
            return int.Parse(DataManager.SETTINGS["medical_leave_per_year"]) - LeaveData.leaves.Sum(x => x.Item5 == LeaveType.MEDICAL_LEAVE && x.Item1.Year == year ? 1 : 0);
        }

        public float cAllowance()    
        {
            return getWorkTime.Allowance.Sum(x => x.Item2);
        }
        public float cPBC()
        {
            return getWorkTime.PBC.Sum(x => x.Item2);
        }
        public float calculateAnnualLeave()
        {
            return LeaveData.leaves.Sum(x => x.Item1.Year == year && x.Item1.Month == month && x.Item5 == LeaveType.ANNUAL_LEAVE ? x.Item4 : 0F);
        }
        public float calculatePaidLeave()
        {
            return LeaveData.leaves.Sum(x => x.Item1.Year == year && x.Item1.Month == month && x.Item5 != LeaveType.UNPAID_LEAVE ? x.Item4 : 0F);
        }

        public float calculateLeave()
        {
            if (!isPartTime && ConfirmDate.HasValue)
            {   
                int month = (DateTime.Now.Month - ConfirmDate.Value.Month) + 12 * (DateTime.Now.Year - ConfirmDate.Value.Year) + 1;
                if (month < 3)
                {
                    return 0;
                }

                if (month < 12)
                {
                    int times = month / 3;
                    return times * (float.Parse(DataManager.SETTINGS["extra_leave_1"]) / 4f) - LeaveData.used_leave;
                }
                else
                {
                    float firstyear = float.Parse(DataManager.SETTINGS["extra_leave_1"]);
                    month = month - 12;

                    int times = month / 3;
                    return times * (float.Parse(DataManager.SETTINGS["extra_leave_2"]) / 4F) + firstyear - LeaveData.used_leave;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}