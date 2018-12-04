using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public class DrivingExpense : Expense
    {
        public DrivingExpense(string title, DateTime date, string description, int amount)
        {
            Title = title;
            Date = date;
            Description = description;
            Amount = amount;
        }
    }
}
