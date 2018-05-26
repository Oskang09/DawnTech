using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
