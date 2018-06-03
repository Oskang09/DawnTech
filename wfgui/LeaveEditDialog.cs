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
    public partial class LeaveEditDialog : Form
    {
        private DataTable DataTable { get; set; }
        private DataView DataView { get; set; }

        private Employee Employee { get; set; }

        public LeaveEditDialog(Employee emp)
        {
            InitializeComponent();
            InitializeView();
        }

        public void InitializeView()
        {
            DataTable = new DataTable();
            DataTable.Columns.Add("DATE");
            DataTable.Columns.Add("REASON");
            DataTable.Columns.Add("MEDICAL FEE");
            DataView = DataTable.DefaultView;
            LeaveData.DataSource = DataView;

            foreach (var wt in Employee.LeaveData.leaves)
            {
                DataTable.Rows.Add(
                    wt.Item1.ToString("MM / dd / yyyy"),
                    wt.Item2,
                    wt.Item3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee.LeaveData.leaves.Add(
                new Tuple<DateTime, string, float>(
                    leaveDate.Value,
                    notes.Rtf,
                    float.Parse(fee.OriText)));
            Employee.LeaveData.used_leave += 1;
            new Employee(leaveDate.Value.Year, leaveDate.Value.Month).getWorkData.readSpecificWorkData(Employee.UID);
            Employee.SaveJson("EMP-" + Employee.UID);
            InitializeView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rowsCount = LeaveData.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            var index = LeaveData.CurrentCell.RowIndex;
            if (MessageBox.Show("Did you want to delete selected leave data?", "Delete leave data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Employee.LeaveData.leaves.RemoveAt(index);
                new Employee(leaveDate.Value.Year, leaveDate.Value.Month).getWorkData.readSpecificWorkData(Employee.UID);
                Employee.SaveJson("EMP-" + Employee.UID);
                DataTable.Rows.RemoveAt(index);
            }
        }

        private void LeaveData_SelectionChanged(object sender, EventArgs e)
        {
            notes.ResetText();
            fee.ResetText();

            var rowsCount = LeaveData.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var index = LeaveData.CurrentCell.RowIndex;
            var tuple = Employee.LeaveData.leaves[index];
            leaveDate.Value = tuple.Item1;
            notes.Rtf = tuple.Item2;
            fee.OriText = tuple.Item3.ToString("0.00");
        }
    }
}
