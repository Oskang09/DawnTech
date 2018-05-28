using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawnTech
{
    public class LeaveData
    {
        public float used_leave { get; set; }

        public float medical_fee { get; set; }

        public List<Tuple<DateTime, string, float>> leaves { get; set; }
    }

}
