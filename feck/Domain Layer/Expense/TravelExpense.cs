using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public class TravelExpense : Expense
    {
        public TravelExpense(string title, DateTime date, string descriptionm, int amount)
        {
            Title = title;
            Date = date;
            Description = descriptionm;
            Amount = amount;
        }
    }
}
