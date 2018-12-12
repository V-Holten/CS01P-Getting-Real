using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public class TravelExpense : Expense
    {
        public enum Type
        {
            Messeomkostninger = 54080,
            Transport = 87020,
            Ophold = 87030,
            Fortæring = 87040,
            Diverse = 87050,
            Repræsentaion = 81020,
            Bankkortgebyr = 96440
        }

        public TravelExpense(string title, string description, DateTime date, double amount, Type type, bool cash) : base(title, description)
        {
            Date = date;
            Amount = amount;
            ExpenseType = type;
            Cash = cash;
        }


        public Type ExpenseType { get; set; }
        public bool Cash { get; set; }
        public DateTime Date { get; private set; }
        public double Amount { get; private set; }
    }
}
