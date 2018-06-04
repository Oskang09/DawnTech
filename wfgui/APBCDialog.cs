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
    public partial class APBCDialog : Form, IFormCallback<FormData>
    {
        private string type { get; set; }
        private WorkTime WorkTime{ get; set; }
        public APBCDialog(WorkTime wt)
        {
            InitializeComponent();
            WorkTime = wt;
        }

        public event EventHandler<FormData> FormEvent;

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            FormEvent(this, new FormData()
            {
                Action = "DONE",
                CallbackData = WorkTime
            });
        }

        public void setName(String text)
        {
            type = text;
            name.Text = text;

            if (type == "Allowance")
            {
                foreach (var str in WorkTime.Allowance)
                {
                    list.Items.Add(str.Item1 + " - RM " + str.Item2.ToString("0.00"));
                }
            }
            if (type == "PBC")
            {
                foreach (var str in WorkTime.PBC)
                {
                    list.Items.Add(str.Item1 + " - RM " + str.Item2.ToString("0.00"));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "Allowance")
            {
                WorkTime.Allowance.Add(new Tuple<string, float>(note.Text, float.Parse(value.OriText)));
                list.Items.Add(note.Text + " - RM " + value.OriText);
            }
            if (type == "PBC")
            {
                WorkTime.PBC.Add(new Tuple<string, float>(note.Text, float.Parse(value.OriText)));
                list.Items.Add(note.Text + " - RM " + value.OriText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list.SelectedIndex > -1)
            {
                if (type == "Allowance")
                {
                    if (MessageBox.Show("Did you really want to delete selected allowance?", "Delete Allowance", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        WorkTime.Allowance.RemoveAt(list.SelectedIndex);
                        list.Items.RemoveAt(list.SelectedIndex);
                    }
                }
                if (type ==  "PBC")
                {
                    if (MessageBox.Show("Did you really want to delete selected pbc?", "Delete PBC", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        WorkTime.PBC.RemoveAt(list.SelectedIndex);
                        list.Items.RemoveAt(list.SelectedIndex);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
