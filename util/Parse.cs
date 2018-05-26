using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawnTech
{
    public class Parser
    {
        public static int GetWorkingDays(int year, int month)
        {
            DateTime from = new DateTime(year, month, 1);
            DateTime to = new DateTime(year, month + 1, 1);
            to.AddDays(-1);

            var dayDifference = (int)to.Subtract(from).TotalDays;
            return Enumerable
                .Range(1, dayDifference)
                .Select(x => from.AddDays(x))
                .Count(x => x.DayOfWeek != DayOfWeek.Saturday && x.DayOfWeek != DayOfWeek.Sunday);
        }

        public static List<Tuple<int, string>> readStringToCheckIn(Range xlr, int row, DateTime dateTime)
        {
            List<Tuple<int, string>> obj = new List<Tuple<int, string>>();
            int days = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            for (int i = 1; i < days + 1; i++)
            {
                obj.Add(new Tuple<int, string>(i, readCell(xlr, row, i)));
            }
            return obj;
        }

        public static DateTime readStringToDateTime(string date)
        {
            string[] from = date.Replace(" ", "").Split('-');
            return new DateTime(int.Parse(from[0]), int.Parse(from[1]), int.Parse(from[2]));
        }

        public static string readCell(Range xlr, int row, int col)
        {
            Range cell = xlr.Cells[row, col];
            return cell.Text;
        }
    }
}
