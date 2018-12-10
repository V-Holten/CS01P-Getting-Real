using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public class TravelExpense : Expense
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }

        public TravelExpense(DateTime date, string description, double amount) 
        {
        
                Date = date;
                Description = description;
                Amount = amount;
         }
    }
}
