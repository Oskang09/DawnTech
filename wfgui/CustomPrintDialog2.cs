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
    public partial class CustomPrintDialog2 : Form, IFormCallback<FormData>
    {
        private CustomEmployee cemp;
        public CustomPrintDialog2(CustomEmployee emp)
        {
            InitializeComponent();
            cemp = emp;
        }

        public event EventHandler<FormData> FormEvent;

        private void done_Click(object sender, EventArgs e)
        {
            cemp.Basic = float.Parse(basic.OriText);
            cemp.PBC = float.Parse(pbc.OriText);
            cemp.Leave = float.Parse(leave.OriText);
            cemp.Late = float.Parse(late.OriText);
            cemp.Allowance = float.Parse(allowance.OriText);
            cemp.Overtime = float.Parse(overtime.OriText);
            cemp.Netpay = float.Parse(netpay.OriText);
            cemp.EPF = float.Parse(epf.OriText);
            cemp.EPF_Boss = float.Parse(epf_boss.Text);
            cemp.Socso = float.Parse(socso.OriText);
            cemp.Socso_Boss = float.Parse(socso_boss.OriText);
            cemp.EIS = float.Parse(eis.OriText);

            FormEvent(sender, new FormData()
            {
                Action = "PRINT",
                CallbackData = cemp
            });
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
