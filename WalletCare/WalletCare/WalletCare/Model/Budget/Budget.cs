using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletCare
{
    public class Budget
    {
        private List<Interaction> interactions;
        private Dictionary<string, Bill> sampleBills;
        private Provider myInvoiceData;

        public int Name { get; set; }

        public void addInteraction(Interaction interaction)
        {
            interactions.Add(interaction);
        }

        public void saveBill(string key, Bill bill)
        {
            sampleBills.Add(key, bill);
        }

        public void setMyInvoiceData(Provider provider)
        {
            myInvoiceData = provider;
        }
    }
}