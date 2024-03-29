﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawnTech
{
    public class LeaveData
    {
        public float used_leave { get; set; }
        
        public List<Tuple<DateTime, string, float, float, LeaveType>> leaves { get; set; }
    }

    public enum LeaveType
    {
        MEDICAL_LEAVE,
        ANNUAL_LEAVE,
        UNPAID_LEAVE
    }

}
