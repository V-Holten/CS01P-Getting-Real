using Domain_Layer.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    public class TravelCompensation : Compensation
    {
        public TravelCompensation(string title, DateTime date) : base(title, date)
        {
        }

        public void AddExpense(TravelExpense expense)
        {
            AddExpense(expense);
        }
    }
}
