using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using CSharpOskaAPI.WF;
using CSharpOskaAPI.UTILITY;

namespace DawnTech.wfgui
{
    public partial class PaySlipUI : UserControl
    {
        public PaySlipUI()
        {
            InitializeComponent();

            when.StringList = string.Join(",", new WorkData().GetListString());
            foreach (var ctl in Recursive.GetAllChildren(tableLayoutPanel1))
            {
                if (ctl is CheckBox)
                {
                    CheckBox cb = ctl as CheckBox;
                    cb.CheckedChanged += delegate
                    {
                        char num = cb.Name[cb.Name.Length - 1];
                        NumberBox nb = Controls.Find("numberBox" + num, true)[0] as NumberBox;
                        nb.Enabled = cb.Checked;
                    };
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (when.SelectedIndex > -1 && employee.SelectedIndex > -1)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (obj, ppe) =>
                {
                    buildPrintingUI(ppe);
                };
                PrintPreviewDialog pvd = new PrintPreviewDialog();
                pvd.Document = pd;
                pd.DefaultPageSettings.PaperSize = new PaperSize("PaperA4", 710, 820);
                pd.DefaultPageSettings.Landscape = true;
                ((Form)pvd).WindowState = FormWindowState.Maximized;
                pvd.PrintPreviewControl.Zoom = 1;
                pvd.ShowDialog();
            }
        }

        public class CustomEmployee
        {
            public String UID { get; set; }
            public String Name { get; set; }
            public String NRIC { get; set; }
            public DateTime JoinDate { get; set; }
            public String DEPT { get; set; }
            public DateTime When { get; set; }

            public float Basic { get; set; }
            public float PBC { get; set; }
            public float Late { get; set; }
            public float Leave { get; set; }
            public float Allowance { get; set; }
            public float Overtime { get; set; }
            public float Netpay { get; set; }
            public float EPF { get; set; }
            public float EPF_Boss { get; set; }
            public float Socso { get; set; }
            public float Socso_Boss { get; set; }
            public float EIS { get; set; }
        }

        public void buildCustomUI(PrintPageEventArgs e, CustomEmployee emp)
        {
            Font ab11 = new Font("Arial Black", 11, FontStyle.Bold);
            Font an10 = new Font("Arial Narrow", 10, FontStyle.Regular);
            Font ab10 = new Font("Arial Black", 10, FontStyle.Bold);
            Font ab9 = new Font("Arial Black", 9, FontStyle.Regular);

            Font an9 = new Font("Arial", 9, FontStyle.Bold);
            Font an9u = new Font("Arial", 9, FontStyle.Bold | FontStyle.Underline);

            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);
            Pen rectagle = new Pen(brush, 4);

            e.Graphics.DrawRectangle(rectagle, new Rectangle(10, 10, 800, 690));
            e.Graphics.DrawString("DAWN TECH ( MALAYSIA ) SDN BHD", ab11, brush, new Point(30, 25));
            e.Graphics.DrawString("SALARY OF " + emp.When.ToString("MMMM yyyy").ToUpper(), ab10, brush, new Point(30, 60));
            e.Graphics.DrawString("MONTHLY PAYROLL", ab9, brush, new Point(50, 105));


            string[] data = new string[]
            {
                emp.UID, emp.Name, emp.NRIC, emp.JoinDate.ToString("yyyy / MM / dd"),
                emp.DEPT,
                "RM " + emp.Basic.ToString("0.00"),
                "RM " + emp.EIS.ToString("0.00"),
                "RM " + emp.EPF.ToString("0"),
                "RM " + emp.Socso.ToString("0.00"),
                "RM " + emp.PBC.ToString("0.00"),
                "RM " + emp.Leave.ToString("0.00"),
                "RM " + emp.Late.ToString("0.00"),
                "RM " + emp.Netpay.ToString("0.00")
            };

            CALC c = new CALC(float.Parse(numberBox1.OriText) + float.Parse(numberBox5.OriText));
            string[] data2 = new string[]
            {
                "RM " + emp.Allowance.ToString("0.00"),
                "RM " + emp.Overtime.ToString("0.00"),
                "RM " + emp.EPF_Boss.ToString("0"),
                "RM " + emp.Socso_Boss.ToString("0.00"),
                "RM " + emp.EIS.ToString("0.00")
            };

            int length = lists_one.OrderByDescending(s => s.Length).First().Length;
            int height_incre = 40;
            for (int i = 0; i < lists_one.Length; i++)
            {
                e.Graphics.DrawString(lists_one[i], an9, brush, new Point(35, 150 + (i * height_incre)));
                e.Graphics.DrawString(":", an9, brush, new Point(80 + (5 * length), 150 + (i * height_incre)));
                e.Graphics.DrawString(data[i], i + 1 == lists_one.Length ? an9u : an9, brush, new Point(105 + (5 * length), 150 + (i * height_incre)));
            }

            e.Graphics.DrawRectangle(rectagle, new Rectangle(400, 150, 360, 130));
            e.Graphics.DrawString("LEAVE RECORD", an9, brush, new Point(410, 160));
            e.Graphics.DrawString("BEFORE", an9u, brush, new Point(520, 185));
            e.Graphics.DrawString("TAKEN", an9u, brush, new Point(600, 185));
            e.Graphics.DrawString("CURRENT", an9u, brush, new Point(680, 185));

            e.Graphics.DrawString("ANNUAL LEAVE", an9, brush, new Point(405, 210));
            e.Graphics.DrawString("MEDICAL FEE", an9, brush, new Point(410, 240));

            float taken = 0;
            float balance = 0;
            float before = 0;

            e.Graphics.DrawString(before.ToString("0.0"), an9, brush, new Point(555 - (before.ToString("0.0").Length * 5), 210));
            e.Graphics.DrawString(taken.ToString("0.0"), an9, brush, new Point(635 - (taken.ToString("0.0").Length * 5), 210));
            e.Graphics.DrawString(balance.ToString("0.0"), an9, brush, new Point(715 - (balance.ToString("0.0").Length * 5), 210));

            float medical_taken = 0;
            float medical_balance = 0;
            float medical_before = 0;

            e.Graphics.DrawString(medical_before.ToString("0.00"), an9, brush, new Point(555 - (medical_before.ToString("0.00").Length * 5), 240));
            e.Graphics.DrawString(medical_taken.ToString("0.00"), an9, brush, new Point(635 - (medical_taken.ToString("0.00").Length * 5), 240));
            e.Graphics.DrawString(medical_balance.ToString("0.00"), an9, brush, new Point(715 - (medical_balance.ToString("0.00").Length * 5), 240));

            e.Graphics.DrawRectangle(rectagle, new Rectangle(490, 540, 300, 120));
            for (int i = 0; i < lists_two.Length; i++)
            {
                e.Graphics.DrawString(lists_two[i], an9, brush, new Point(500, 150 + ((8 + i) * height_incre)));
                e.Graphics.DrawString(":", an9, brush, new Point(580 + (5 * length), 150 + ((8 + i) * height_incre)));
                e.Graphics.DrawString(data2[i], an9, brush, new Point(605 + (5 * length), 150 + ((8 + i) * height_incre)));
            }

            e.Graphics.DrawString(numberBox6.OriText.DollarToText(), an9, brush, new Point(30, 680));
        }

        public void buildPrintingUI(PrintPageEventArgs e)
        {
            Font ab11 = new Font("Arial Black", 11, FontStyle.Bold);
            Font an10 = new Font("Arial Narrow", 10, FontStyle.Regular);
            Font ab10 = new Font("Arial Black", 10, FontStyle.Bold);
            Font ab9 = new Font("Arial Black", 9, FontStyle.Regular);

            Font an9 = new Font("Arial", 9, FontStyle.Bold);
            Font an9u = new Font("Arial", 9, FontStyle.Bold | FontStyle.Underline);

            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);
            Pen rectagle = new Pen(brush, 4);
            WorkData wd = new WorkData().LoadJson(when.Text);
            Employee emp = new Employee().LoadJson("EMP-" + employee.Text).setParameters(wd.When.Year, wd.When.Month);

            e.Graphics.DrawRectangle(rectagle, new Rectangle(10, 10, 800, 690));
            e.Graphics.DrawString("DAWN TECH ( MALAYSIA ) SDN BHD", ab11, brush, new Point(30, 25));
            e.Graphics.DrawString("SALARY OF " + wd.When.ToString("MMMM yyyy").ToUpper(), ab10, brush, new Point(30, 60));
            e.Graphics.DrawString("MONTHLY PAYROLL", ab9, brush, new Point(50, 105));


            string[] data = new string[]
            {
                emp.UID, emp.Name, emp.NRIC, emp.JoinDate.ToString("yyyy / MM / dd"),
                emp.DEPT,
                checkBox1.Checked ? numberBox1.Text : "RM " + emp.Basic.ToString("0.00"),
                checkBox4.Checked ? numberBox4.Text : "RM " + emp.cEIS().ToString("0.00"),
                checkBox2.Checked ? numberBox2.Text : "RM " + emp.cEPF(EPFType.EMPLOYEE).ToString("0"),
                checkBox3.Checked ? numberBox3.Text : "RM " + emp.cSocso(SocsoType.EMPLOYEE).ToString("0.00"),
                checkBox8.Checked ? numberBox8.Text : "RM " + emp.cPBC().ToString("0.00"),
                "RM " + emp.cLeave().ToString("0.00"),
                "RM " + emp.cLate().ToString("0.00"),
                checkBox6.Checked ? numberBox6.Text : "RM " + emp.cNetPay(SocsoType.EMPLOYEE, EPFType.EMPLOYEE).ToString("0.00"),
            };

            string[] data2 = new string[]
            {
                checkBox7.Checked ? numberBox7.Text : "RM " + emp.cAllowance().ToString("0.00"),
                checkBox5.Checked ? numberBox5.Text : "RM " + emp.cTotalOT().ToString("0.00"),
                "RM " + emp.cEPF(EPFType.BOSS).ToString("0.00"),
                "RM " + emp.cSocso(SocsoType.BOSS).ToString("0.00"),
                "RM " + emp.cEIS().ToString("0.00")
            };

            int length = lists_one.OrderByDescending(s => s.Length).First().Length;
            int height_incre = 40;
            for (int i = 0; i < lists_one.Length; i++)
            {
                e.Graphics.DrawString(lists_one[i], an9, brush, new Point(35, 150 + (i * height_incre)));
                e.Graphics.DrawString(":", an9, brush, new Point(80 + (5 * length), 150 + (i * height_incre)));
                e.Graphics.DrawString(data[i], i + 1 == lists_one.Length ? an9u : an9, brush, new Point(105 + (5 * length), 150 + (i * height_incre)));
            }

            e.Graphics.DrawRectangle(rectagle, new Rectangle(400, 150, 360, 130));
            e.Graphics.DrawString("LEAVE RECORD", an9, brush, new Point(410, 160));
            e.Graphics.DrawString("BEFORE", an9u, brush, new Point(520, 185));
            e.Graphics.DrawString("TAKEN", an9u, brush, new Point(600, 185));
            e.Graphics.DrawString("CURRENT", an9u, brush, new Point(680, 185));

            e.Graphics.DrawString("ANNUAL LEAVE", an9, brush, new Point(405, 210));
            e.Graphics.DrawString("MEDICAL FEE", an9, brush, new Point(410, 240));

            float taken = emp.calculateAnnualLeave();
            float balance = emp.calculateLeave();
            float before = balance + taken;

            e.Graphics.DrawString(before.ToString("0.0"), an9, brush, new Point(555 - ( before.ToString("0.0").Length * 5), 210));
            e.Graphics.DrawString(taken.ToString("0.0"), an9, brush, new Point(635 - (taken.ToString("0.0").Length * 5), 210));
            e.Graphics.DrawString(balance.ToString("0.0"), an9, brush, new Point(715 - (balance.ToString("0.0").Length * 5), 210));

            float medical_taken = emp.cMedicalMonth();
            float medical_balance = emp.cMedicalYear() + medical_taken;
            float medical_before = medical_taken + medical_balance;

            e.Graphics.DrawString(medical_before.ToString("0.00"), an9, brush, new Point(555 - (medical_before.ToString("0.00").Length * 5), 240));
            e.Graphics.DrawString(medical_taken.ToString("0.00"), an9, brush, new Point(635 - (medical_taken.ToString("0.00").Length * 5), 240));
            e.Graphics.DrawString(medical_balance.ToString("0.00"), an9, brush, new Point(715 - (medical_balance.ToString("0.00").Length * 5), 240));

            e.Graphics.DrawRectangle(rectagle, new Rectangle(490, 540, 300, 120));
            for (int i = 0; i< lists_two.Length;i++)
            {
                e.Graphics.DrawString(lists_two[i], an9, brush, new Point(500, 150 + ((8 + i ) * height_incre)));
                e.Graphics.DrawString(":", an9, brush, new Point(580 + (5 * length), 150 + ((8 + i) * height_incre)));
                e.Graphics.DrawString(data2[i], an9, brush, new Point(605 + (5 * length), 150 + ((8 + i) * height_incre)));
            }

            e.Graphics.DrawString(checkBox6.Checked ? numberBox6.Text.DollarToText() : emp.cNetPay(SocsoType.EMPLOYEE, EPFType.EMPLOYEE).ToString("0.00").DollarToText(), an9, brush, new Point(30, 680));
        }

        string[] lists_one = new string[]
        {
            "Employee No.", "Name", "IC No", "Date Joined",
            "Production", "Basic Pay", "EIS", "EPF Employee", "SOCSO Employee",
            "PCB", "Leave", "Late", "Net Pay"
        };

        string[] lists_two = new string[]
        {
            "Allowance", "Overtime", "EPF Employer", "SOCSO Employer", "EIS Employer"
        };

        private void when_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (when.SelectedIndex > -1)
            {
                List<string> list = new WorkData().LoadJson(when.Text).EMPLOYEES.Keys.ToList();
                List<string> objs = new List<string>();
                foreach (var str in new Employee().GetListString())
                {
                    objs.Add(str.Substring(4));
                }
                employee.StringList = string.Join(",", list.Intersect(objs).ToList());
            }
        }

        private void employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employee.SelectedIndex > -1)
            {
                WorkData wd = new WorkData().LoadJson(when.Text);
                Employee emp = new Employee().LoadJson("EMP-" + employee.Text).setParameters(wd.When.Year, wd.When.Month);
                numberBox1.OriText = emp.Basic.ToString("0.00");
                numberBox2.OriText = emp.cEPF(EPFType.EMPLOYEE).ToString("0");
                numberBox3.OriText = emp.cSocso(SocsoType.EMPLOYEE).ToString("0.00");
                numberBox4.OriText = emp.cEIS().ToString("0.00");
                numberBox5.OriText = emp.cOvertime().ToString("0.00");
                numberBox6.OriText = emp.cNetPay(SocsoType.EMPLOYEE, EPFType.EMPLOYEE).ToString("0.00");
                numberBox7.OriText = emp.cAllowance().ToString("0.00");
                numberBox8.OriText = emp.cPBC().ToString("0.00");
            }
        }

        private void custom_Click(object sender, EventArgs e)
        {
            CustomPrintDialog cpd = new CustomPrintDialog();
            cpd.FormEvent += (s, fd) =>
            {
                if (fd.Action == "PRINT")
                {
                    CustomPrintDialog2 cpd2 = new CustomPrintDialog2((CustomEmployee)fd.CallbackData);
                    cpd2.FormEvent += (s2, fd2) =>
                    {
                        if (fd.Action == "PRINT")
                        {
                            PrintDocument pd = new PrintDocument();
                            pd.PrintPage += (obj, ppe) =>
                            {
                                buildCustomUI(ppe, (CustomEmployee)fd2.CallbackData);
                            };
                            PrintPreviewDialog pvd = new PrintPreviewDialog();
                            pvd.Document = pd;
                            pd.DefaultPageSettings.PaperSize = new PaperSize("PaperA4", 710, 820);
                            pd.DefaultPageSettings.Landscape = true;
                            ((Form)pvd).WindowState = FormWindowState.Maximized;
                            pvd.PrintPreviewControl.Zoom = 1;
                            pvd.ShowDialog();
                        }
                    };
                    cpd2.ShowDialog();
                }
            };
            cpd.ShowDialog();
        }
    }
}
