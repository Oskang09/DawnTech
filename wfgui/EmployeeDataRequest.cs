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
                float total_leave = 0;
                if (leave.OriText != "")
                {
                    if (confirm.Checked)
                    {
                        int month = (DateTime.Now.Month - confirm_date.Value.Month) + 12 * (DateTime.Now.Year - confirm_date.Value.Year);
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
                        BankAcc = bankacc.Text != "" ? bankacc.Text : "",
                        BankName = bankname.Text != "" ? bankname.Text : "",
                        ConfirmDate = confirm.Checked ? confirm_date.Value : (DateTime?)null,
                        JoinDate = join_date.Value,
                        NRIC = nric.Text != "" ? nric.Text : "",
                        isPartTime = isPart.Checked,
                        LeaveData = new LeaveData()
                        {
                            used_leave = leave.OriText != "" ? total_leave - float.Parse(leave.OriText) : 0,
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

        private void confirm_CheckedChanged(object sender, EventArgs e)
        {
            confirm_date.Enabled = confirm.Checked;
        }
    }
}
