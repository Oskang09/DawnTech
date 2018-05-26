using CSharpOskaAPI;
using NCalc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawnTech
{
    public enum SocsoType
    {
        EMPLOYEE,
        BOSS,
        NONE
    }

    public enum EISType
    {
        EMPLOYEE,
        BOSS,
        NONE
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

        private int year { get; set; }
        private int month { get; set; }

        // EmployeeData
        public string UID { get; set; }
        public string Name { get; set; }
        public string DEPT { get; set; }
        public int Age { get; set; }

        public double Basic { get; set; }

        public bool useEpf { get; set; }
        public int percentageEpf { get; set; }

        public bool useSocso { get; set; }
        public SocsoType SocsoType { get; set; }

        public bool useEIS { get; set; }
        public EISType EISType { get; set; }

        public WorkData getWorkData => new WorkData().LoadJson($"{year}-{month}");
        public WorkTime getWorkTime => getWorkData.EMPLOYEES[UID];

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
            return Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero);
        }
        public double cLeave()
        {
            var exp = new Expression(DataManager.SETTINGS["leave"]);
            exp.Parameters["day"] = getWorkTime.Leave;
            exp.Parameters["basic"] = Basic;
            exp.Parameters["working_day"] = getWorkData.Working_Day;
            return Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero);
        }

        public double cOvertime()
        {
            var exp = new Expression(DataManager.SETTINGS["overtime"]);
            exp.Parameters["hour"] = Convert.ToInt32(getWorkTime.Overtime / 60);
            exp.Parameters["basic"] = Basic;
            exp.Parameters["working_day"] = getWorkData.Working_Day;
            return Math.Round((double)exp.Evaluate(), 1, MidpointRounding.AwayFromZero);
        }

        public double cEPF()
        {
            return useEpf ?
                Math.Round(cGrossPay() * ( (double)percentageEpf / 100.0 ), 1, MidpointRounding.AwayFromZero) :
                0;
        }

        public double cSocso()
        {
            return Math.Round(new CALC(cGrossPay()).cSocso(SocsoType), 1, MidpointRounding.AwayFromZero);
        }

        public double cEIS()
        {
            return  Math.Round(new CALC(cGrossPay()).cEIS(), 1, MidpointRounding.AwayFromZero);
        }

        public double cTotal()
        {
            return  Math.Round(cGrossPay() - 
                ( useEpf ? cEPF() : 0 ) -
                ( useEIS ? cEIS() : 0 ) -
                ( useSocso ? cSocso() : 0 ), 1, MidpointRounding.AwayFromZero);
        }

        public double cNetPay()
        {
            return Math.Round(cTotal() - cLate(), 1, MidpointRounding.AwayFromZero);
        }
    }
}