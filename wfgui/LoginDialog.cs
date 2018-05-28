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
    public partial class LoginDialog : Form
    {
        private string user { get; set; }
        private string password { get; set; }
        public LoginDialog(string username, string password)
        {
            InitializeComponent();
            this.user = username;
            this.password = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text != user || pass.Text != password)
            {
                message.Text = "Wrong username or password!";
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
