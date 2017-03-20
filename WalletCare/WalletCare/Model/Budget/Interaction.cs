using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletCare
{
    public abstract class Interaction
    {
        public int Value { get; set; }

        public string ImageReference { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Note { get; set; }

        public Repeat Repeat { get; }

        public int Category { get; set; }
    }
}