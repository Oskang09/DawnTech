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
                        percentageEpf = checkBox1.Checked ? int.Parse(percentageEPF.OriText) : 0
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
