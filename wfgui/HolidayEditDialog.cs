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
    public partial class HolidayEditDialog : Form, IFormCallback<FormData>
    {
        private WorkData WorkData { get; set; }
        public HolidayEditDialog(WorkData wd)
        {
            InitializeComponent();
            WorkData = wd;
            DATE_DISPLAY.Text = WorkData.When.Year.ToString() + "-" + WorkData.When.Month.ToString();

            foreach (var tuple in wd.Holidays)
            {
                holidays.Items.Add(tuple.Item2.ToString("dd/MM") + " - " + tuple.Item1);
            }

            date.MinDate = new DateTime(wd.When.Year, wd.When.Month, 1);
            if (wd.When.Month == 12)
            {
                date.MaxDate = new DateTime(wd.When.Year + 1, 1, 1).AddDays(-1);
            }
            else
            {
                date.MaxDate = new DateTime(wd.When.Year, wd.When.Month + 1, 1).AddDays(-1);
            }
        }

        public event EventHandler<FormData> FormEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            holidays.Items.Add(date.Value.ToString("dd/MM") + " - " + holiday_name.Text);
            WorkData.Holidays.Add(new Tuple<string, DateTime>(holiday_name.Text,
                date.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (holidays.SelectedIndex > -1)
            {
                if (MessageBox.Show("Did you really want to delete selected public holiday?", "Delete Holiday", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    WorkData.Holidays.RemoveAt(holidays.SelectedIndex);
                    holidays.Items.RemoveAt(holidays.SelectedIndex);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            WorkData.R_readToWorkData();
            FormEvent(this, new FormData()
            {
                Action = "DONE",
                CallbackData = WorkData
            });
        }

        private void holidays_SelectedIndexChanged(object sender, EventArgs e)
        {
            holiday_name.ResetText();
            if (holidays.SelectedIndex > -1)
            {
                var tuple = WorkData.Holidays[holidays.SelectedIndex];

                holiday_name.Text = tuple.Item1;
                date.Value = tuple.Item2;
            }
        }
    }
}
