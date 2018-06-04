using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpOskaAPI.WF;
using CSharpOskaAPI.Parse;

namespace DawnTech.wfgui
{
    public partial class EmployeeDataDisplay : UserControl, IFormCallback<FormData>, IUpdateUI
    {
        private string[] sortbylist = { "EMP NO", "NAME", "DEPT", "AGE", "NRIC" };
        private DataView DataView { get; set; }
        private DataTable DataTable { get; set; }
        private bool editMode { get; set; }
        public event EventHandler<FormData> FormEvent;

        public EmployeeDataDisplay()
        {
            InitializeComponent();
            InitializeView();
            editMode = false;

            foreach (var str in sortbylist)
            {
                SortBy.Items.Add(str);
            }
            SortBy.SelectedIndex = 0;
        }

        public void UpdateUI()
        {
            InitializeView();
        }

        public void InitializeView()
        {
            DataTable = new DataTable();
            DataTable.Columns.Add("EMP NO");
            DataTable.Columns.Add("NAME");
            DataTable.Columns.Add("DEPT");
            DataTable.Columns.Add("AGE");
            DataTable.Columns.Add("NRIC");
            DataTable.Columns.Add("LEAVE");
            DataView = DataTable.DefaultView;
            EmployeeDataDGV.DataSource = DataView;
            foreach (var emp in new Employee().GetList())
            {
                DataTable.Rows.Add(
                    emp.UID,
                    emp.Name,
                    emp.DEPT,
                    emp.Age,
                    emp.NRIC,
                    emp.calculateLeave());
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FormEvent(sender, new FormData()
            {
                Action = "OpenRequest"
            });
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            editMode = !editMode;
            foreach (var ctl in Recursive.GetAllChildren(InputLayout))
            {
                if (ctl == confirm_date) continue;
                if (ctl is TextBox) ((TextBox)ctl).ReadOnly = !((TextBox)ctl).ReadOnly;
                if (ctl is CheckBox) ((CheckBox)ctl).Enabled = !((CheckBox)ctl).Enabled;
                if (ctl is ComboBox) ((ComboBox)ctl).Enabled = !((ComboBox)ctl).Enabled;
                if (ctl is DateTimePicker) ((DateTimePicker)ctl).Enabled = !((DateTimePicker)ctl).Enabled;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(basic.OriText);
            if (editMode)
            {
                if (EmployeeDataDGV.SelectedRows.Count == 1)
                {
                    var uid = EmployeeDataDGV.SelectedRows[0].Cells[0];
                    if (uid.Value.ToString() == empno.Text)
                    {
                        float total_leave = 0;
                        LeaveData ld = new Employee().LoadJson("EMP-" + empno.Text).LeaveData;
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
                            ld.used_leave = total_leave - float.Parse(leave.OriText);
                        }

                        Employee emp = new Employee()
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
                            LeaveData = ld
                        };
                        emp.SaveJson("EMP-" + empno.Text);


                        string temp = empno.Text;
                        DataRow[] dr = DataTable.Select($"[EMP NO]='{empno.Text}'");
                        dr[0].Delete();

                        DataTable.Rows.Add(
                            emp.UID,
                            emp.Name,
                            emp.DEPT,
                            emp.Age,
                            emp.NRIC,
                            emp.calculateLeave());

                        return;
                    }

                    if (uid.ToString() != empno.Text && DataTable.AsEnumerable().Where(row => row.Field<string>("EMP NO").Equals("")).Count() > 0)
                    {
                        MessageBox.Show("Repeated value!");
                    }
                    else
                    {
                        float total_leave = 0;
                        LeaveData ld = new Employee().LoadJson("EMP-" + uid.Value.ToString()).LeaveData;
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
                            ld.used_leave = total_leave - float.Parse(leave.OriText);
                        }
                        // Update
                        Employee emp = new Employee()
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
                            ConfirmDate = confirm.Checked ? confirm_date.Value : (DateTime?) null,
                            JoinDate = join_date.Value,
                            NRIC = nric.Text != "" ? nric.Text : "",
                            isPartTime = isPart.Checked,
                            LeaveData = ld
                        };
                        emp.DeleteJson("EMP-" + uid.Value.ToString());
                        emp.SaveJson("EMP-" + empno.Text);

                        DataRow[] dr = DataTable.Select($"[EMP NO]='{uid.Value.ToString()}'");
                        dr[0].Delete();

                        DataTable.Rows.Add(
                            emp.UID,
                            emp.Name,
                            emp.DEPT,
                            emp.Age,
                            emp.NRIC,
                            emp.calculateLeave());
                    }
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeDataDGV.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Did you want to delete selected employee?\n* Warning : After delete cant be recover without restore from backup", "Delete Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var uid = EmployeeDataDGV.SelectedRows[0].Cells[0];
                    new Employee().DeleteJson(uid.Value.ToString());

                    DataRow[] dr = DataTable.Select($"[EMP NO]='{uid.Value.ToString()}'");
                    dr[0].Delete();

                    MainWindow.GetInstance.RDD.UpdateComboBox();
                    MainWindow.GetInstance.LED.UpdateComboBox();
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            FormEvent(sender, new FormData()
            {
                Action = "ExitUI"
            });
        }

        private void SortBox_TextChanged(object sender, EventArgs e)
        {
            DataView.RowFilter = $"[{SortBy.Text}] LIKE '*{SortBox.Text}*'";
        }

        private void SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView.RowFilter = $"[{SortBy.Text}] LIKE '*{SortBox.Text}*'";
        }

        private void EmployeeDataDGV_SelectionChanged(object sender, EventArgs e)
        {
            foreach (var ctl in Recursive.GetAllChildren(InputLayout))
            {
                if (ctl is TextBox) ctl.ResetText();
                if (ctl is ComboBox) (ctl as ComboBox).SelectedIndex = -1;
                if (ctl is CheckBox) (ctl as CheckBox).Checked = false;
            }

            var rowsCount = EmployeeDataDGV.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var uid = EmployeeDataDGV.SelectedRows[0].Cells[0];
            var employee = new Employee().LoadJson("EMP-" + uid.Value.ToString());
            if (employee != null)
            {
                empno.Text = ObjectParse.ObjectParseString(employee.UID);
                dept.Text = ObjectParse.ObjectParseString(employee.DEPT);
                name.Text = ObjectParse.ObjectParseString(employee.Name);
                age.Text = ObjectParse.ObjectParseString(employee.Age);
                basic.OriText = employee.Basic.ToString("0.00");

                checkBox1.Checked = employee.useEpf;
                checkBox2.Checked = employee.useSocso;
                checkBox3.Checked = employee.useEIS;

                nric.Text = ObjectParse.ObjectParseString(employee.NRIC);
                bankacc.Text = ObjectParse.ObjectParseString(employee.BankAcc);
                bankname.Text = ObjectParse.ObjectParseString(employee.BankName);
                join_date.Value = employee.JoinDate;
                isPart.Checked = employee.isPartTime;
                if (employee.ConfirmDate.HasValue)
                {
                    confirm.Checked = true;
                    confirm_date.Value = employee.ConfirmDate.Value;
                }
                leave.Text = employee.calculateLeave().ToString();
            }

        }

        private void confirm_CheckedChanged(object sender, EventArgs e)
        {
            if (editMode) confirm_date.Enabled = confirm.Checked;
        }
    }
}
