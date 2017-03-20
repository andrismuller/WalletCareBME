using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletCare
{
    public class Provider
    {
        public string Name { get; set; }

        public Address Address { get; }

        public string TaxIdentificationNumber { get; set; }

        public string BankAccountNumber { get; set; }

        public string BusinessLicenseNumber { get; set; }
    }
}