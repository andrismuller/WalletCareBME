using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletCare
{
    public class Income : Interaction
    {
        private Bill bill;

        public Income()
        {

        }

        public Bill Bill { get { return bill; } }

        public void setBill(Provider provider, Customer customer, PaymentData paymentData)
        {
            bill.Customer = customer;
            bill.PaymentData = paymentData;
            bill.Provider = provider;
        }
    }
}