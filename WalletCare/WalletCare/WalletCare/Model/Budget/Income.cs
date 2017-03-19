using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletCare
{
    public class Income : Interaction
    {
        private static List<string> CategoriesOfIncome;
        public string Category { get; set; }
        private Bill bill;

        public Income()
        {
            CategoriesOfIncome.Add("Salary");
            CategoriesOfIncome.Add("Other");
        }

        public Bill Bill { get { return bill; } }

        public void setBill(Provider provider, Customer customer, PaymentData paymentData)
        {
            bill.setCustomer(customer);
            bill.setPaymentData(paymentData);
            bill.setProvider(provider);
        }
    }
}