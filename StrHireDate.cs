﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal struct StrHireDate
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

        public string showDate()
        {
            return $"Day:{Day} Month:{Month} Year:{Year}";
        }
    }
}
