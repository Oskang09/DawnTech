using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DawnTech.wfgui.PaySlipUI;

namespace DawnTech.wfgui
{
    public partial class CustomPrintDialog : Form, IFormCallback<FormData>
    {
        public CustomPrintDialog()
        {
            InitializeComponent();
        }

        public event EventHandler<FormData> FormEvent;

        private void done_Click(object sender, EventArgs e)
        {
            FormEvent(sender, new FormData()
            {
                Action = "PRINT",
                CallbackData = new CustomEmployee()
                {
                    UID = empno.Text,
                    Name = name.Text,
                    NRIC = nric.Text,
                    DEPT = dept.Text,
                    JoinDate = join_date.Value,
                    When = month.Value
                }
            });
            Close();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
