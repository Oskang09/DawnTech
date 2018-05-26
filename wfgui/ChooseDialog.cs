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
    public partial class ChooseDialog : Form, IFormCallback<FormData>
    {
        public ChooseDialog()
        {
            InitializeComponent();
        }

        public void set(string title, string infostr, IEnumerable<string> content)
        {
            Text = title;
            info.Text = infostr;
            list.Items.AddRange(content.ToArray());
        }

        public event EventHandler<FormData> FormEvent;

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (list.SelectedIndex > -1)
            {
                FormEvent(OKBtn, new FormData()
                {
                    Action = "DATA",
                    CallbackData = list.SelectedIndex
                });
            }
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
