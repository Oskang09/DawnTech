using DawnTech.wfgui;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DawnTech
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public EmployeeDataDisplay EDD { get; set; }
        public ReportDataDisplay RDD { get; set; }
        public LeaveEditDialog LED { get; set; }
        public PaySlipUI PSU { get; set; }

        public static MainWindow GetInstance { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            GetInstance = this;
            new DataManager();
            LoginDialog ld = new LoginDialog(DataManager.SETTINGS["username"], DataManager.SETTINGS["password"]);
            if (ld.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitializeUI();
            }
            else
            {
                Close();
            }
        }

        public void InitializeUI()
        {
            EDD = new EmployeeDataDisplay();
            EDD.FormEvent += (sender_a, data) =>
            {
                if (data.Action == "OpenRequest")
                {
                    EmployeeDataRequest edr = new EmployeeDataRequest();
                    edr.FormEvent += (sender_b, data_b) =>
                    {
                        if (data_b.Action == "NEW_DATA")
                        {
                            Employee emp = data_b.CallbackData as Employee;
                            emp.SaveJson("EMP-" + emp.UID);
                            EDD.UpdateUI();
                        }
                    };
                    edr.Show();
                }
                if (data.Action == "ExitUI")
                {
                    WFContent.Child = null;
                }
            };
            RDD = new ReportDataDisplay();
            LED = new LeaveEditDialog();
            PSU = new PaySlipUI();
        }

        private void ReportUI(object sender, RoutedEventArgs e)
        {
            WFContent.Child = RDD;
            RDD.Focus();
        }

        private void EmployeeUI(object sender, RoutedEventArgs e)
        {
            WFContent.Child = EDD;
            EDD.Focus();
        }

        private void PayslipUI(object sender, RoutedEventArgs e)
        {
            WFContent.Child = PSU;
            PSU.Focus();
        }

        private void LeaveEdit(object sender, RoutedEventArgs e)
        {
            WFContent.Child = LED;
            LED.Focus();
        }
    }
}
