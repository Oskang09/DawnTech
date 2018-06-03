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
    public partial class HolidayEditDialog : Form
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkData.Holidays.Add(new Tuple<string, DateTime>(holiday_name.Text,
                date.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (holidays.SelectedIndex > -1)
            {
                holidays.Items.RemoveAt(holidays.SelectedIndex);
                WorkData.Holidays.RemoveAt(holidays.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkData.readToWorkData();
            Close();
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
