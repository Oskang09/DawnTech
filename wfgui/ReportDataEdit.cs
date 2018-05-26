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
            WorkData = new WorkData();
        }

        public event EventHandler<FormData> FormEvent;

        public void setDate(DateTime date)
        {
            DATE.Text = $"{date.Year}-{date.Month}";
            WorkData.LoadJson(DATE.Text);
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
                var data = WorkData.EMPLOYEES.First(x => x.Key == employeeList.Text).Value;
                leave.Text = data.Leave.ToString();
                ot.Text = data.Overtime.ToString();
                worked.Text = data.Worked.ToString();
                late.Text = data.Late.ToString();
                worked_day.Text = data.Worked_Day.ToString();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            WorkData.Working_Day = int.Parse(working_day.OriText);
            if (employeeList.SelectedIndex > -1)
            {
                WorkData.EMPLOYEES[employeeList.Text] = new WorkTime()
                {
                    Worked_Day = int.Parse(worked_day.OriText),
                    Worked = int.Parse(worked.Text),
                    Late = int.Parse(late.OriText),
                    Leave = int.Parse(leave.OriText),
                    Overtime = int.Parse(ot.Text)
                };
                MessageBox.Show($"Updated EMPLOYEE({employeeList.Text})'s data!", "Update Employee Data");
            }
        }

        private void employeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var ctl in Recursive.GetAllChildren(InputLayout))
            {
                if (ctl is TextBox) ctl.ResetText();
            }
            if (employeeList.SelectedIndex > -1)
            {
                var data = WorkData.EMPLOYEES.First(x => x.Key == employeeList.Text).Value;
                leave.Text = data.Leave.ToString();
                ot.Text = data.Overtime.ToString();
                worked.Text = data.Worked.ToString();
                late.Text = data.Late.ToString();
                worked_day.Text = data.Worked_Day.ToString();
            }
        }
    }
}
