using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpOskaAPI.UTILITY;
using Microsoft.Office.Interop.Excel;

namespace DawnTech
{
    public class TimelineExcel
    {
        // From & To
        public DateTime When { get; set; }
        public List<CheckData> CheckData { get; set; }

        public void saveWorkData()
        {
                WorkData wd = new WorkData();
                wd.When = When;
                wd.EMPLOYEES = new Dictionary<string, WorkTime>();

                foreach (var worker in CheckData)
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
                        wd.EMPLOYEES[worker.UID] = new WorkTime()
                        {
                            Late = late,
                            Overtime = overtime,
                            Leave = leave,
                            Worked = worked_minute,
                            Worked_Day = worked_day
                        };
                    }

                    wd.When = When;
                    wd.Working_Day = Parser.GetWorkingDays(When.Year, When.Month);
                    wd.SaveJson($"{wd.When.Year}-{wd.When.Month}");
                }
            
            /*
            catch (Exception ex)
            {
                MessageBox.Show("The excel file is not original generated!\nERROR : " + ex.Message, "ERROR Format Wrongly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }
    }

    public class CheckData
    {
        public string UID { get; set; }
        // Day , Time ( split every 5 char ) before use
        public List<Tuple<int, string>> CheckIn { get; set; }
    }
}
