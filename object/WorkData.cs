using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpOskaAPI.UTILITY;
using DawnTech.wfgui;

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
        public List<Tuple<string, DateTime>> Holidays { get; set; }
        public List<ExcelData> ExcelData { get; set; }

        public void readSpecificWorkData(string UID)
        {
            try
            {
                var data = ExcelData.First(x => x.UID == UID);

                int late = 0;
                int worked_minute = 0;
                int overtime = 0;
                int worked_day = 0;
                int holiday_ot = 0;
                List<DateTime> leaves = new List<DateTime>();

                foreach (var ck in data.CheckIn)
                {
                    if (ck.Item2 == "")
                    {
                        leaves.Add(new DateTime(When.Year, When.Month, ck.Item1));
                        continue;
                    }
                    worked_day++;
                    var time = ck.Item2.SplitInParts(5).ToArray();
                    for (int i = 0; i < time.Count(); i += 2)
                    {
                        if (i + 1 >= time.Count()) break;

                        DateTime dt = new DateTime(When.Year, When.Month, ck.Item1);
                        if (i == 0)
                        {
                            if (!dt.Is(DayOfWeek.Sunday) && !Holidays.Any(x => x.Item2.Year == dt.Year && x.Item2.Month == dt.Month && x.Item2.Day == dt.Day))
                            {
                                TimeSpan should_at = TimeSpan.ParseExact(DataManager.SETTINGS["before_late"], "hh\\:mm", CultureInfo.InvariantCulture);
                                TimeSpan first_check = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                                TimeSpan ts = first_check.Subtract(should_at);
                                if (ts.TotalMinutes > 0)
                                {
                                    late += 1;
                                    if (Convert.ToInt32(ts.TotalMinutes) >= int.Parse(DataManager.SETTINGS["late_interval"]))
                                    {
                                        late += Convert.ToInt32(ts.TotalMinutes) / int.Parse(DataManager.SETTINGS["late_interval"]);
                                    }
                                }
                            }
                        }

                        if (Holidays.Any(x => x.Item2.Year == dt.Year && x.Item2.Month == dt.Month && x.Item2.Day == dt.Day) || dt.Is(DayOfWeek.Sunday))
                        {
                            TimeSpan checkin = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                            TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                            if (checkout.Subtract(checkin).TotalMinutes > 0)
                            {
                                holiday_ot += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                            }
                        }
                        else if (dt.Is(DayOfWeek.Saturday))
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
                                if (checkout.Subtract(checkin).TotalMinutes >= 30)
                                {
                                    overtime += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                }
                                else
                                {
                                    worked_minute += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                }
                            }
                            else
                            {
                                TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                                if (checkout.Subtract(ot_time).TotalMinutes >= 0)
                                {
                                    worked_minute += Convert.ToInt32(ot_time.Subtract(checkin).TotalMinutes);

                                    if (checkout.Subtract(ot_time).TotalMinutes >= 30)
                                    {
                                        overtime += Convert.ToInt32(checkout.Subtract(ot_time).TotalMinutes);
                                    }
                                    else
                                    {   
                                        worked_minute += Convert.ToInt32(checkout.Subtract(ot_time).TotalMinutes);
                                    }

                                }
                                else
                                {
                                    worked_minute += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                }
                            }
                        }
                    }
                }

                if (EMPLOYEES.TryGetValue(data.UID, out var temp_wt))
                {
                    EMPLOYEES[data.UID] = new WorkTime()
                    {
                        Late = late,
                        Overtime = overtime,
                        Worked = worked_minute,
                        Leaves = leaves,
                        Worked_Day = worked_day,
                        Allowance = temp_wt.Allowance,
                        PBC = temp_wt.PBC,
                        HolidayOT = holiday_ot
                    };
                }
                else
                {
                    EMPLOYEES[data.UID] = new WorkTime()
                    {
                        Late = late,
                        Overtime = overtime,
                        Worked = worked_minute,
                        Leaves = leaves,
                        Worked_Day = worked_day,
                        HolidayOT = holiday_ot,
                        Allowance = new List<Tuple<string, float>>(),
                        PBC = new List<Tuple<string, float>>()
                    };
                }
                SaveJson($"{When.Year}-{When.Month}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The excel file is not original generated!\nERROR : " + ex.Message, "ERROR Format Wrongly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void R_readToWorkData()
        {
            try
            {
                foreach (var worker in ExcelData)
                {
                    int late = 0;
                    int worked_minute = 0;
                    int overtime = 0;
                    int worked_day = 0;
                    int holiday_ot = 0;
                    List<DateTime> leaves = new List<DateTime>();

                    foreach (var ck in worker.CheckIn)
                    {
                        if (ck.Item2 == "")
                        {
                            leaves.Add(new DateTime(When.Year, When.Month, ck.Item1));
                            continue;
                        }
                        worked_day++;
                        var time = ck.Item2.SplitInParts(5).ToArray();
                        for (int i = 0; i < time.Count(); i += 2)
                        {
                            if (i + 1 >= time.Count()) break;

                            DateTime dt = new DateTime(When.Year, When.Month, ck.Item1);
                            if (i == 0)
                            {
                                if (!dt.Is(DayOfWeek.Sunday) && !Holidays.Any(x => x.Item2.Year == dt.Year && x.Item2.Month == dt.Month && x.Item2.Day == dt.Day))
                                {
                                    TimeSpan should_at = TimeSpan.ParseExact(DataManager.SETTINGS["before_late"], "hh\\:mm", CultureInfo.InvariantCulture);
                                    TimeSpan first_check = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                                    TimeSpan ts = first_check.Subtract(should_at);
                                    if (ts.TotalMinutes > 0)
                                    {
                                        late += 1;
                                        if (Convert.ToInt32(ts.TotalMinutes) >= int.Parse(DataManager.SETTINGS["late_interval"]))
                                        {
                                            late += Convert.ToInt32(ts.TotalMinutes) / int.Parse(DataManager.SETTINGS["late_interval"]);
                                        }
                                    }
                                }
                            }

                            if (Holidays.Any(x => x.Item2.Year == dt.Year && x.Item2.Month == dt.Month && x.Item2.Day == dt.Day) || dt.Is(DayOfWeek.Sunday))
                            {
                                TimeSpan checkin = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                                TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                                if (checkout.Subtract(checkin).TotalMinutes > 0)
                                {
                                    holiday_ot += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                }
                            }
                            else if (dt.Is(DayOfWeek.Saturday))
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
                                    if (checkout.Subtract(checkin).TotalMinutes >= 30)
                                    {
                                        overtime += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                    }
                                    else
                                    {
                                        worked_minute += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                    }
                                }
                                else
                                {
                                    TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                                    if (checkout.Subtract(ot_time).TotalMinutes >= 0)
                                    {
                                        worked_minute += Convert.ToInt32(ot_time.Subtract(checkin).TotalMinutes);

                                        if (checkout.Subtract(ot_time).TotalMinutes >= 30)
                                        {
                                            overtime += Convert.ToInt32(checkout.Subtract(ot_time).TotalMinutes);
                                        }
                                        else
                                        {
                                            worked_minute += Convert.ToInt32(checkout.Subtract(ot_time).TotalMinutes);
                                        }

                                    }
                                    else
                                    {
                                        worked_minute += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                    }
                                }
                            }
                        }
                    }
                    
                    if (worker.UID == "10")
                    {
                        Console.WriteLine("OT - " + overtime + " Holiday - " + holiday_ot);
                    }
                    if (EMPLOYEES.TryGetValue(worker.UID, out var temp_wt))
                    {
                        EMPLOYEES[worker.UID] = new WorkTime()
                        {
                            Late = late,
                            Overtime = overtime,
                            Worked = worked_minute,
                            Worked_Day = worked_day,
                            Allowance = temp_wt.Allowance,
                            Leaves = leaves,
                            HolidayOT = holiday_ot,
                            PBC = temp_wt.PBC
                        };
                    }
                    else
                    {
                        EMPLOYEES[worker.UID] = new WorkTime()
                        {
                            Late = late,
                            Overtime = overtime,
                            Worked = worked_minute,
                            Worked_Day = worked_day,
                            HolidayOT = holiday_ot,
                            Leaves = leaves,
                            Allowance = new List<Tuple<string, float>>(),
                            PBC = new List<Tuple<string, float>>()
                        };
                    }
                }
                SaveJson($"{When.Year}-{When.Month}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The excel file is not original generated!\nERROR : " + ex.Message, "ERROR Format Wrongly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void readToWorkData()
        {
            try
            {
                EMPLOYEES = new Dictionary<string, WorkTime>();
                Holidays = new List<Tuple<string, DateTime>>();
                Working_Day = int.Parse(DataManager.SETTINGS["working_day"]);
                foreach (var worker in ExcelData)
                {
                    int late = 0;
                    int worked_minute = 0;
                    int overtime = 0;
                    int worked_day = 0;
                    int holiday_ot = 0;
                    List<DateTime> leaves = new List<DateTime>();
                    
                    foreach (var ck in worker.CheckIn)
                    {
                        if (ck.Item2 == "")
                        {
                            leaves.Add(new DateTime(When.Year, When.Month, ck.Item1));
                            continue;
                        }
                        worked_day++;
                        var time = ck.Item2.SplitInParts(5).ToArray();
                        for (int i = 0; i < time.Count(); i += 2)
                        {
                            if (i + 1 >= time.Count()) break;

                            DateTime dt = new DateTime(When.Year, When.Month, ck.Item1);
                            if (i == 0)
                            {
                                if (!dt.Is(DayOfWeek.Sunday) && !Holidays.Any(x => x.Item2.Year == dt.Year && x.Item2.Month == dt.Month && x.Item2.Day == dt.Day))
                                {
                                    TimeSpan should_at = TimeSpan.ParseExact(DataManager.SETTINGS["before_late"], "hh\\:mm", CultureInfo.InvariantCulture);
                                    TimeSpan first_check = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                                    TimeSpan ts = first_check.Subtract(should_at);
                                    if (ts.TotalMinutes > 0)
                                    {
                                        late += 1;
                                        if (Convert.ToInt32(ts.TotalMinutes) >= int.Parse(DataManager.SETTINGS["late_interval"]))
                                        {
                                            late += Convert.ToInt32(ts.TotalMinutes) / int.Parse(DataManager.SETTINGS["late_interval"]);
                                        }
                                    }
                                }
                            }

                            if (Holidays.Any(x => x.Item2.Year == dt.Year && x.Item2.Month == dt.Month && x.Item2.Day == dt.Day) || dt.Is(DayOfWeek.Sunday))
                            {
                                TimeSpan checkin = TimeSpan.ParseExact(time[i], "hh\\:mm", CultureInfo.InvariantCulture);
                                TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                                if (checkout.Subtract(checkin).TotalMinutes > 0)
                                {
                                    holiday_ot += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                }
                            }
                            else if (dt.Is(DayOfWeek.Saturday))
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
                                    if (checkout.Subtract(checkin).TotalMinutes >= 30)
                                    {
                                        overtime += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                    }
                                    else
                                    {
                                       worked_minute += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                    }
                                }
                                else
                                {
                                    TimeSpan checkout = TimeSpan.ParseExact(time[i + 1], "hh\\:mm", CultureInfo.InvariantCulture);
                                    if (checkout.Subtract(ot_time).TotalMinutes >= 0)
                                    {
                                        worked_minute += Convert.ToInt32(ot_time.Subtract(checkin).TotalMinutes);

                                        if (checkout.Subtract(ot_time).TotalMinutes >= 30)
                                        {
                                            overtime += Convert.ToInt32(checkout.Subtract(ot_time).TotalMinutes);
                                        }
                                        else
                                        {
                                            worked_minute += Convert.ToInt32(checkout.Subtract(ot_time).TotalMinutes);
                                        }

                                    }
                                    else
                                    {
                                        worked_minute += Convert.ToInt32(checkout.Subtract(checkin).TotalMinutes);
                                    }
                                }
                            }
                        }
                    }
                    if (worker.UID == "10")
                    {
                        Console.WriteLine("OT - " + overtime);
                        Console.WriteLine("holiday_ot -" + holiday_ot);
                    }
                    EMPLOYEES[worker.UID] = new WorkTime()
                    {
                        Late = late,
                        Overtime = overtime,
                        Worked = worked_minute,
                        Worked_Day = worked_day,
                        HolidayOT = holiday_ot,
                        Allowance = new List<Tuple<string, float>>(),
                        Leaves = leaves,
                        PBC = new List<Tuple<string, float>>()
                    };
                }
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
        public List<DateTime> Leaves { get; set; }
        public int HolidayOT { get; set; }
        // Minutes
        public int Overtime { get; set; }
        // Minutes
        public int Worked { get; set; }
        // Times = 30 min + 1
        public int Late { get; set; }
        public int Worked_Day { get; set; }
        public List<Tuple<string, float>> Allowance { get; set; }
        public List<Tuple<string, float>> PBC { get; set; }
    }
    public class ExcelData
    {
        public string UID { get; set; }
        // Day , Time ( split every 5 char ) before use
        public List<Tuple<int, string>> CheckIn { get; set; }
    }
}
