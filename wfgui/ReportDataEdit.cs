using CSharpOskaAPI.WF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DawnTech.wfgui
{
    public partial class ReportDataEdit: Form , IFormCallback<FormData>
    {
        public WorkData WorkData { get; set; }
        public ReportDataEdit()
        {
            InitializeComponent();
        }

        public event EventHandler<FormData> FormEvent;

        public void setDate(DateTime date)
        {
            DATE.Text = $"{date.Year}-{date.Month}";
            WorkData = new WorkData().LoadJson(DATE.Text);

            ph_counter.Text = WorkData.Holidays.Count.ToString();
            working_day.Text = WorkData.Working_Day.ToString();
            
            employeeList.StringList = string.Join("," ,WorkData.EMPLOYEES.Keys);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            FormEvent(this, new FormData()
            {
                Action = "DONE",
                CallbackData = WorkData
            });
        }

        private void defaultBtn_Click(object sender, EventArgs e)
        {
            working_day.Text = WorkData.Working_Day.ToString();
            ph_counter.Text = WorkData.Holidays.Count.ToString();
            foreach (var ct in WorkData.EMPLOYEES)
            {
                employeeList.Items.Add(ct.Key);
            }

            foreach (var ctl in Recursive.GetAllChildren(InputLayout))
            {
                if (ctl is TextBox) ctl.ResetText();
            }

            if (employeeList.SelectedIndex > -1)
            {
                if (WorkData.EMPLOYEES.ContainsKey(employeeList.Text))
                {
                    var data = WorkData.EMPLOYEES[employeeList.Text];
                    leave.OriText = data.Leave.ToString();
                    ot.OriText = data.Overtime.ToString();
                    worked.OriText = data.Worked.ToString();
                    late.OriText = data.Late.ToString();
                    worked_day.OriText = data.Worked_Day.ToString();
                    allowance.OriText= data.Allowance.Sum(x => x.Item2).ToString("0.00");
                    pbc.OriText = data.PBC.Sum(x => x.Item2).ToString("0.00");
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            WorkData.Working_Day = int.Parse(working_day.OriText);
            if (employeeList.SelectedIndex > -1)
            {
                var temp = WorkData.EMPLOYEES[employeeList.Text];
                WorkData.EMPLOYEES[employeeList.Text] = new WorkTime()
                {
                    Worked_Day = int.Parse(worked_day.OriText),
                    Worked = int.Parse(worked.OriText),
                    Late = int.Parse(late.OriText),
                    Leave = int.Parse(leave.OriText),
                    Overtime = int.Parse(ot.OriText),
                    Allowance = temp.Allowance,
                    PBC = temp.PBC
                };
                MessageBox.Show($"Updated EMPLOYEE({employeeList.Text})'s data!", "Update Employee's Data");
            }
            WorkData.SaveJson($"{WorkData.When.Year}-{WorkData.When.Month}");
        }

        private void employeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputLayout.Visible = false;
            foreach (var ctl in Recursive.GetAllChildren(InputLayout))
            {
                if (ctl is TextBox) ctl.ResetText();
            }
            if (employeeList.SelectedIndex > -1)
            {
                var data = WorkData.EMPLOYEES.First(x => x.Key == employeeList.Text).Value;
                leave.OriText = (data.Leave - new Employee().LoadJson("EMP-" + employeeList.Text).LeaveData.leaves.Sum(x => x.Item1.Year + "-" + x.Item1.Month == DATE.Text ? 1 : 0)).ToString();
                ot.OriText = data.Overtime.ToString();
                worked.OriText = data.Worked.ToString();
                late.OriText = data.Late.ToString();
                worked_day.OriText = data.Worked_Day.ToString();
                allowance.OriText = data.Allowance.Sum(x => x.Item2).ToString("0.00");
                pbc.OriText = data.PBC.Sum(x => x.Item2).ToString("0.00");
                InputLayout.Visible = true;
            }
        }

        private void holidayEdit_Click(object sender, EventArgs e)
        {
            HolidayEditDialog hed = new HolidayEditDialog(WorkData);
            hed.FormEvent += (s, fd) =>
            {
                if (fd.Action == "DONE")
                {
                    WorkData = (WorkData) fd.CallbackData;
                    defaultBtn.PerformClick();
                }
            };
            hed.ShowDialog();
        }

        private void allowanceEdit_Click(object sender, EventArgs e)
        {
            if (employeeList.SelectedIndex > -1 && new Employee().Exists("EMP-" + employeeList.Text))
            {
                APBCDialog apbc = new APBCDialog(WorkData.EMPLOYEES[employeeList.Text]);
                apbc.setName("Allowance");
                apbc.FormEvent += (s, fd) =>
                {
                    if (fd.Action == "DONE")
                    {
                        WorkData.EMPLOYEES[employeeList.Text] = (WorkTime) fd.CallbackData;
                        defaultBtn.PerformClick();
                    }
                };
                apbc.ShowDialog();
            }
        }

        private void pbcEdit_Click(object sender, EventArgs e)
        {
            if (employeeList.SelectedIndex > -1 && new Employee().Exists("EMP-" + employeeList.Text))
            {
                APBCDialog apbc = new APBCDialog(WorkData.EMPLOYEES[employeeList.Text]);
                apbc.setName("PBC");
                apbc.FormEvent += (s, fd) =>
                {
                    if (fd.Action == "DONE")
                    {
                        WorkData.EMPLOYEES[employeeList.Text] = (WorkTime)fd.CallbackData;
                        defaultBtn.PerformClick();
                    }
                };
                apbc.ShowDialog();
            }
        }
    }
}
