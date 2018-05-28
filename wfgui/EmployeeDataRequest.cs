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
    public partial class EmployeeDataRequest : Form, IFormCallback<FormData>
    {
        public EmployeeDataRequest()
        {
            InitializeComponent();
        }

        public event EventHandler<FormData> FormEvent;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!new Employee().Exists(empno.Text))
            {
                int month = (DateTime.Now.Month - confirm_date.Value.Month) + 12 * (DateTime.Now.Year - confirm_date.Value.Year);
                float total_leave = 0;
                if (month > 3)
                {
                    if (month < 12)
                    {
                        int times = month / 3;
                        total_leave = times * (float.Parse(DataManager.SETTINGS["extra_leave_1"]) / 4f);
                    }
                    else
                    {
                        float firstyear = float.Parse(DataManager.SETTINGS["extra_leave_1"]);
                        month = month - 12;

                        int times = month / 3;
                        total_leave = times * (float.Parse(DataManager.SETTINGS["extra_leave_2"]) / 4F) + firstyear;
                    }
                }

                FormEvent(sender, new FormData()
                {
                    Action = "NEW_DATA",
                    CallbackData = new Employee()
                    {
                        UID = empno.Text != "" ? empno.Text : "",
                        Name = name.Text != "" ? name.Text : "",
                        DEPT = dept.Text != "" ? dept.Text : "",
                        Age = age.OriText != "" ? int.Parse(age.OriText) : 0,
                        Basic = basic.OriText != "" ? double.Parse(basic.OriText) : 0,
                        useEpf = checkBox1.Checked,
                        useSocso = checkBox2.Checked,
                        useEIS = checkBox3.Checked,
                        EISType = checkBox3.Checked ? (EISType)Enum.Parse(typeof(EISType), eistype.Text) : EISType.NONE,
                        SocsoType = checkBox2.Checked ? (SocsoType)Enum.Parse(typeof(SocsoType), socsoType.Text) : SocsoType.NONE,
                        percentageEpf = checkBox1.Checked ? int.Parse(percentageEPF.OriText) : 0,
                        BankAcc = bankacc.Text != "" ? bankacc.Text : "",
                        BankName = bankname.Text != "" ? bankname.Text : "",
                        ConfirmDate = confirm_date.Value,
                        JoinDate = join_date.Value,
                        NRIC = nric.Text != "" ? nric.Text : "",
                        LeaveData = new LeaveData()
                        {
                            used_leave = total_leave - float.Parse(leave.OriText),
                            leaves = new List<Tuple<DateTime, string, float>>(),
                            medical_fee = 500
                        }
                    }
                });
                Close();
            }
            else
            {
                // Employee Exists
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            percentageEPF.ReadOnly = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            socsoType.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            eistype.Enabled = checkBox3.Checked;
        }
    }
}
