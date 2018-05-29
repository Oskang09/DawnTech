using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpOskaAPI.UTILITY;

namespace DawnTech
{
    public class WorkData : IJsonObject<WorkData>
    {
        public WorkData() : base("workdata/")
        {

        }

        public DateTime When { get; set; }
        public Dictionary<string, WorkTime> EMPLOYEES { get; set; }
        public int Working_Day { get; set; }
        public List<DateTime> Holidays { get; set; }
        public List<ExcelData> ExcelData { get; set; }

        public void readToWorkData()
        {
            try
            {
                EMPLOYEES = new Dictionary<string, WorkTime>();

                foreach (var worker in ExcelData)
                {
                    int late = 0;
                    int leave = 0;
                    int worked_minute = 0;
                    int overtime = 0;
                    int worked_day = 0;

                    foreach (var ck in worker.CheckIn)
                    {
                        if (ck.Item2 == null) continue;

                        worked_day++;
                        var time = ck.Item2.SplitInParts(5).ToArray();
                        for (int i = 0; i < time.Count(); i += 2)
                        {
                            if (i + 1 >= time.Count()) break;

                            if (i == 0)
                            {
                                TimeSpan should_at = TimeSpan.ParseExact(DataManager.SETTINGS["before_late"], "hh\\:mm", CultureInfo.InvariantCulture);
                                TimeSpan first_check = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                                TimeSpan ts = first_check.Subtract(should_at);
                                if (ts.TotalMinutes > 0)
                                {
                                    late += 1;
                                    if (ts.TotalMinutes >= 30)
                                    {
                                        late += Convert.ToInt32(ts.TotalMinutes) / int.Parse(DataManager.SETTINGS["late_interval"]);
                                    }
                                }
                            }
                            DateTime dt = new DateTime(When.Year, When.Month, ck.Item1);
                            if (dt.Is(DayOfWeek.Sunday) || dt.Is(DayOfWeek.Saturday) || Holidays.Contains(dt))
                            {
                                TimeSpan checkin = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                                TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                                if (checkout.Subtract(checkin).TotalMinutes > 0)
                                {
                                    overtime += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                }
                            }
                            else
                            {
                                TimeSpan checkin = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                                TimeSpan ot_time = TimeSpan.ParseExact(DataManager.SETTINGS["over_time"], "hh\\:mm", CultureInfo.InvariantCulture);
                                if (checkin.Subtract(ot_time).TotalMinutes >= 0)
                                {
                                    TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                                    overtime += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                }
                                else
                                {
                                    TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                                    if (checkout.Subtract(ot_time).TotalMinutes >= 0)
                                    {
                                        overtime += Convert.ToInt32(checkout.Subtract(ot_time).TotalMinutes);
                                        worked_minute += Convert.ToInt32(ot_time.Subtract(checkin).TotalMinutes);
                                    }
                                    else
                                    {
                                        worked_minute += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                    }
                                }
                            }
                        }
                    }
                    EMPLOYEES[worker.UID] = new WorkTime()
                    {
                        Late = late,
                        Overtime = overtime,
                        Leave = leave,
                        Worked = worked_minute,
                        Worked_Day = worked_day
                    };
                }
                Working_Day = Parser.GetWorkingDays(When.Year, When.Month);
                SaveJson($"{When.Year}-{When.Month}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The excel file is not original generated!\nERROR : " + ex.Message, "ERROR Format Wrongly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class WorkTime
    {
        // Day ( Total Working day - worked day )
        public int Leave { get; set; }
        // Minutes
        public int Overtime { get; set; }
        // Minutes
        public int Worked { get; set; }
        // Times = 30 min + 1
        public int Late { get; set; }
        public int Worked_Day { get; set; }
    }
    public class ExcelData
    {
        public string UID { get; set; }
        // Day , Time ( split every 5 char ) before use
        public List<Tuple<int, string>> CheckIn { get; set; }
    }
}
