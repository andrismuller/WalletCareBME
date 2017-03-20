using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletCare
{
    public class Repeat
    {
        public DateTime EndDate { get; set; }

        public Period RepeatPeriod { get; set; }

        public Period RepeatFrequency { get; set; }

        public int RepeatPeriodNumber { get; set; }

        public int RepeatFrequencyNumber { get; set; }

        public DateTime NextRepeatDate { get; set; }

        public string Type { get; set; }
    }
}