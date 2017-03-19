using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletCare
{
    public class Expense : Interaction
    {
        private static List<string> CategoriesOfExpense;
        public string Category { get; set; }

        public Expense()
        {
            CategoriesOfExpense = new List<string>();
            CategoriesOfExpense.Add("Food");
            CategoriesOfExpense.Add("Household");
            CategoriesOfExpense.Add("Saving");
            CategoriesOfExpense.Add("Goal");
            CategoriesOfExpense.Add("Loan");
            CategoriesOfExpense.Add("Children");
            CategoriesOfExpense.Add("Entertainment");
            CategoriesOfExpense.Add("Travel");
            CategoriesOfExpense.Add("Holiday");
            CategoriesOfExpense.Add("Other");
        }

    }
}