using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DawnTech.wfgui
{
    public partial class ReportDataDisplay : UserControl
    {   
        private DataView DataView { get; set; }
        private DataTable DataTable { get; set; }

        public ReportDataDisplay()
        {
            InitializeComponent();
            InitializeUI();
        }

        public void InitializeUI()
        {
            DataTable = new DataTable();
            DataTable.Columns.Add("NAME");
            DataTable.Columns.Add("EMP NO");
            DataTable.Columns.Add("DEPT");
            DataTable.Columns.Add("BASIC");
            DataTable.Columns.Add("OVERTIME");
            DataTable.Columns.Add("LEAVE");
            DataTable.Columns.Add("GROSS PAY");
            DataTable.Columns.Add("EPF EMPLOYEE");
            DataTable.Columns.Add("SOCSO EMPLOYEE");
            DataTable.Columns.Add("SOCSO BOSS");
            DataTable.Columns.Add("EIS EMPLOYEE");
            DataTable.Columns.Add("TOTAL");
            DataTable.Columns.Add("LATE");
            DataTable.Columns.Add("NETPAY");
            DataView = DataTable.DefaultView;
            SUM_DATA.DataSource = DataView;
            UpdateComboBox();
        }

        public void UpdateComboBox()
        {
            when_cbox.StringList = string.Join(",", new WorkData().GetListString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable.Rows.Clear();
            if (when_cbox.SelectedIndex > -1)
            {
                WorkData wd = new WorkData().LoadJson(when_cbox.Text);
                foreach (var worker in wd.EMPLOYEES)
                {
                    if (new Employee().Exists("EMP-" + worker.Key))
                    {
                        Employee emp = new Employee().LoadJson("EMP-" + worker.Key).setParameters(wd.When.Year, wd.When.Month);

                        DataTable.Rows.Add(
                            emp.Name,
                            emp.UID,
                            emp.DEPT,
                           "RM " + emp.Basic.ToString("0.00"),
                            "RM " + emp.cOvertime().ToString("0.00"),
                            "RM " + emp.cLeave().ToString("0.00"),
                            "RM " + emp.cGrossPay().ToString("0.00"),
                            "RM " + emp.cEPF().ToString("0.00"),
                            "RM " + emp.cSocso(SocsoType.EMPLOYEE).ToString("0.00"),
                            "RM " + emp.cEIS().ToString("0.00"),
                            "RM " + emp.cTotal(SocsoType.EMPLOYEE).ToString("0.00"),
                            "RM " + emp.cSocso(SocsoType.BOSS).ToString("0.00"),
                            "RM " + emp.cLate().ToString("0.00"),
                            "RM " + emp.cNetPay(SocsoType.EMPLOYEE).ToString("0.00"));
                    }
                    else
                    {
                        DataTable.Rows.Add("Not exists!",
                            worker.Key);
                    }
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (when_cbox.SelectedIndex > -1)
            {
                ReportDataEdit rde = new ReportDataEdit();
                string[] ar = when_cbox.Text.Split('-');
                rde.setDate(new DateTime(int.Parse(ar[0]), int.Parse(ar[1]), 1));
                rde.FormEvent += (form, form_data) =>
                {
                    if (form_data.Action == "DONE")
                    {
                        comboBox1_SelectedIndexChanged(sender, e);
                    }
                };
                rde.Show();
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 97-2003 fiels (*.xls)|*.xls|All files (*.*)|*.*";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelReader er = new ExcelReader(ofd.FileName);
                    ChooseDialog cd = new ChooseDialog();
                    cd.set("Excel's sheets", "Choose the sheet, you want to import", er.getSheets());
                    cd.FormEvent += (form_sender, form_data) =>
                    {
                        var tle = er.readExcel((int)form_data.CallbackData + 1);
                        if (new WorkData().Exists($"{tle.When.Year}-{tle.When.Month}"))
                        {
                            if (MessageBox.Show("There already have a data exists. Did you want to replace it?", "Data Exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                tle.readToWorkData();
                            }
                        }
                        else
                        {
                            tle.readToWorkData();
                        }
                        er.close();
                        UpdateComboBox();
                    };
                    cd.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurs when try to opening the excel files!\n" + ex.Message);
                }
            }
        }
    }
}
