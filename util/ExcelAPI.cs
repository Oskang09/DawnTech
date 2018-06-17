using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace DawnTech
{
    public class ExcelAPI
    {
        private Application App { get; set; }
        private Workbook Workbook { get; set; }
        private _Worksheet WorkSheet { get; set; }
        private Range Range { get; set; }

        public ExcelAPI(string file)
        {
            App = new Application();
            Workbook = App.Workbooks.Open(file);
        }

        public ExcelAPI()
        {
            App = new Application();
        }

        public List<string> getSheets()
        {
            var lists = new List<string>();

            for (int i = 1; i < Workbook.Sheets.Count + 1; i++)
            {
                _Worksheet wd = Workbook.Sheets[i];
                lists.Add(wd.Name);
            }
            return lists;
        }

        public void ExportExcel(String tablename, WorkData wd, String path)
        {
            Workbook = App.Workbooks.Add(Type.Missing);
            WorkSheet = Workbook.ActiveSheet;
            WorkSheet.Name = wd.When.Year + "-" + wd.When.Month;

            WorkSheet.Cells[1, 1] = "NO";
            WorkSheet.Cells[1, 2] = "NAME";
            WorkSheet.Cells[1, 3] = "EMP NO";
            WorkSheet.Cells[1, 4] = "DEPT";

            WorkSheet.Cells[1, 5] = "BASIC";
            WorkSheet.Cells[1, 6] = "OVERTIME";
            WorkSheet.Cells[1, 7] = "LEAVE";
            WorkSheet.Cells[1, 8] = "GROSS PAY";
            WorkSheet.Cells[1, 9] = "EPF EMPLOYEE";
            WorkSheet.Cells[1, 10] = "SOCSO EMPLOYEE";
            WorkSheet.Cells[1, 11] = "EIS EMPLOYEE";
            WorkSheet.Cells[1, 12] = "ALLOWANCE";
            WorkSheet.Cells[1, 13] = "TOTAL";
            WorkSheet.Cells[1, 14] = "LATE";
            WorkSheet.Cells[1, 15] = "PBC";
            WorkSheet.Cells[1, 16] = "NET PAY";
            WorkSheet.Cells[1, 17] = "EPF EMPLOYER";
            WorkSheet.Cells[1, 18] = "SOCSO EMPLOYER";
            WorkSheet.Cells[1, 19] = "EIS EMPLOYER";

            int start_row = 2;
            int employeeCounter = 1;
            var employees = wd.EMPLOYEES.Keys.OrderBy(x => int.Parse(x)).ToList();
            double[] total = new double[15];
            foreach (var data in employees)
            {
                if (new Employee().Exists("EMP-" + data, out Employee emp))
                {
                    emp.setParameters(wd.When.Year, wd.When.Month);
                    WorkSheet.Cells[start_row, 1] = employeeCounter++;
                    WorkSheet.Cells[start_row, 2] = emp.Name;
                    WorkSheet.Cells[start_row, 3] = emp.UID;
                    WorkSheet.Cells[start_row, 4] = emp.DEPT;

                    WorkSheet.Cells[start_row, 5] = emp.Basic.ToString("0.00");
                    WorkSheet.Cells[start_row, 6] = emp.cOvertime().ToString("0.00");
                    WorkSheet.Cells[start_row, 7] = emp.cLeave().ToString("0.00");
                    WorkSheet.Cells[start_row, 8] = emp.cGrossPay().ToString("0.00");
                    WorkSheet.Cells[start_row, 9] = emp.cEPF(EPFType.EMPLOYEE).ToString("0");
                    WorkSheet.Cells[start_row, 10] = emp.cSocso(SocsoType.EMPLOYEE).ToString("0.00");
                    WorkSheet.Cells[start_row, 11] = emp.cEIS().ToString("0.00");
                    WorkSheet.Cells[start_row, 12] = emp.cAllowance().ToString("0.00");
                    WorkSheet.Cells[start_row, 13] = emp.cTotal(SocsoType.EMPLOYEE, EPFType.EMPLOYEE).ToString("0.00");
                    WorkSheet.Cells[start_row, 14] = emp.cLate().ToString("0.00");
                    WorkSheet.Cells[start_row, 15] = emp.cPBC().ToString("0.00");
                    WorkSheet.Cells[start_row, 16] = emp.cNetPay(SocsoType.EMPLOYEE, EPFType.EMPLOYEE).ToString("0.00");
                    WorkSheet.Cells[start_row, 17] = emp.cEPF(EPFType.BOSS).ToString("0");
                    WorkSheet.Cells[start_row, 18] = emp.cSocso(SocsoType.BOSS).ToString("0.00");
                    WorkSheet.Cells[start_row, 19] = emp.cEIS().ToString("0.00");

                    total[0] += emp.Basic;
                    total[1] += emp.cOvertime();
                    total[2] += emp.cLeave();
                    total[3] += emp.cGrossPay();
                    total[4] += emp.cEPF(EPFType.EMPLOYEE);
                    total[5] += emp.cSocso(SocsoType.EMPLOYEE);
                    total[6] += emp.cEIS();
                    total[7] += emp.cAllowance();
                    total[8] += emp.cTotal(SocsoType.EMPLOYEE, EPFType.EMPLOYEE);
                    total[9] += emp.cLate();
                    total[10] += emp.cPBC();
                    total[11] += emp.cNetPay(SocsoType.EMPLOYEE, EPFType.EMPLOYEE);
                    total[12] += emp.cEPF(EPFType.BOSS);
                    total[13] += emp.cSocso(SocsoType.BOSS);
                    total[14] += emp.cEIS();

                    start_row++;
                }
            }
            Range rn = WorkSheet.Range[WorkSheet.Cells[start_row, 1], WorkSheet.Cells[start_row, 4]];
            rn.Merge();

            WorkSheet.Cells[start_row, 1] = "TOTAL";
            WorkSheet.Cells[start_row, 5] = total[0].ToString("0.00");
            WorkSheet.Cells[start_row, 6] = total[1].ToString("0.00");
            WorkSheet.Cells[start_row, 7] = total[2].ToString("0.00");
            WorkSheet.Cells[start_row, 8] = total[3].ToString("0.00");
            WorkSheet.Cells[start_row, 9] = total[4].ToString("0");
            WorkSheet.Cells[start_row, 10] = total[5].ToString("0.00");
            WorkSheet.Cells[start_row, 11] = total[6].ToString("0.00"); 
            WorkSheet.Cells[start_row, 12] = total[7].ToString("0.00"); 
            WorkSheet.Cells[start_row, 13] = total[8].ToString("0.00"); 
            WorkSheet.Cells[start_row, 14] = total[9].ToString("0.00");
            WorkSheet.Cells[start_row, 15] = total[10].ToString("0.00");
            WorkSheet.Cells[start_row, 16] = total[11].ToString("0.00");
            WorkSheet.Cells[start_row, 17] = total[12].ToString("0");
            WorkSheet.Cells[start_row, 18] = total[13].ToString("0.00");
            WorkSheet.Cells[start_row, 19] = total[14].ToString("0.00");


            rn = WorkSheet.Range[WorkSheet.Cells[1, 1], WorkSheet.Cells[start_row, 19]];
            rn.EntireColumn.AutoFit();
            rn.EntireRow.AutoFit();
            Workbook.SaveAs(path);
        }

        public WorkData readExcel(int sheets)
        {
            WorkData tle = new WorkData();
            tle.Holidays = new List<Tuple<string, DateTime>>();
            _Worksheet Ws = Workbook.Sheets[sheets];

            Range xlR = Ws.UsedRange;

            int rowC = xlR.Rows.Count;
            int colC = xlR.Columns.Count;

            string[] date = Parser.readCell(xlR, 3, 3).Split('~');
            tle.When = Parser.readStringToDateTime(date[0]);

            List<ExcelData> data = new List<ExcelData>();
            int start_row = 5;
            for (int sr = start_row; sr < rowC; sr += 2)
            {
                data.Add(new ExcelData()
                {
                    UID = Parser.readCell(xlR, sr, 3),
                    CheckIn = Parser.readStringToCheckIn(xlR, sr + 1, tle.When)
                });
            }
            tle.ExcelData = data;
            return tle;
        }

        public void close()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Workbook.Close(0);
            Marshal.FinalReleaseComObject(Workbook);
            App.Quit();
            Marshal.FinalReleaseComObject(App);
        }
    }
}
