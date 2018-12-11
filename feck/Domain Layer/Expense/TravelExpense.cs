using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public class TravelExpense : Expense
    {
        public TravelExpense(string title, string description, DateTime date, double amount) : base(title, description)
        {
            Date = date;
            Amount = amount;
        }

        public DateTime Date { get; private set; }
        public double Amount { get; private set; }
    }
}
