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
        private List<List<string>> categories = new List<List<string>>();

        public int Name { get; set; }

        public Budget()
        {
            categories.Add(new List<string>());
            categories.Add(new List<string>());
            categories[1].Add("Food");
            categories[1].Add("Lending");
            categories[1].Add("Travel");
            categories[1].Add("Bill");
            categories[1].Add("Household");
            categories[1].Add("Shopping");
            categories[1].Add("Entertainment");
            categories[1].Add("Health");
            categories[1].Add("Study");
            categories[1].Add("Other");
            categories[1].Add("Saving");
            categories[1].Add("Goal");
            categories[1].Add("Loan");
            categories[1].Add("Children");
            categories[1].Add("Holiday");

            categories[2].Add("Salary");
            categories[2].Add("Gift");
            categories[2].Add("Debt");
            categories[2].Add("Other");
        }

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