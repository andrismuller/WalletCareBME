using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletCare
{
    public class Bill
    {
        public Provider Provider { get; set; }
        public Customer Customer { get; set; }
        public PaymentData PaymentData { get; set; }

    }
}