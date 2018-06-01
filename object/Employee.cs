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

        public double cGrossPay()
        {
            return Math.Round(Basic + cOvertime() + cLeave(), 2);
        }

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
            exp.Parameters["day"] = getWorkTime.Leave;
            exp.Parameters["basic"] = Basic;
            exp.Parameters["working_day"] = getWorkData.Working_Day;
            return !isPartTime ? Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero) : 0;
        }

        public double cOvertime()
        {
            var exp = new Expression(DataManager.SETTINGS["overtime"]);
            exp.Parameters["hour"] = Convert.ToInt32(getWorkTime.Overtime / 60);
            exp.Parameters["basic"] = Basic;
            exp.Parameters["working_day"] = getWorkData.Working_Day;
            return !isPartTime ? Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero) : 0;
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
                Math.Round(new CALC(cGrossPay()).cSocso(st), 1, MidpointRounding.AwayFromZero) : 
                0;
        }

        public double cEIS()
        {
            return !isPartTime && useEIS ?
                Math.Round(new CALC(cGrossPay()).cEIS(), 1, MidpointRounding.AwayFromZero) : 
                0;
        }

        public double cTotal(SocsoType st, EPFType epf)
        {
            return Math.Round(cGrossPay() - cEPF(epf) - cEIS() - cSocso(st), 1, MidpointRounding.AwayFromZero);
        }

        public double cNetPay(SocsoType st, EPFType epf)
        {
            return Math.Round(cTotal(st, epf) - cLate() - calculatePBC() + calculateAllowance(), 1, MidpointRounding.AwayFromZero);
        }

        public float calculateMedical()
        {
            float total = 0F;
            foreach (var tp in LeaveData.leaves)
            {
                if (tp.Item1.Year == DateTime.Now.Year)
                {
                    return total += tp.Item3;
                }
            }
            return LeaveData.medical_fee - total;
        }

        public float calculateAllowance()
        {
            return getWorkTime.Allowance.Sum(x => x.Item2);
        }
        public float calculatePBC()
        {
            return getWorkTime.PBC.Sum(x => x.Item2);
        }

        public float calculateLeave()
        {
            if (!isPartTime && ConfirmDate.HasValue)
            {
                int month = (DateTime.Now.Month - ConfirmDate.Value.Month) + 12 * (DateTime.Now.Year - ConfirmDate.Value.Year);
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