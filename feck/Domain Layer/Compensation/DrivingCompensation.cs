using Domain_Layer.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    public class DrivingCompensation : Compensation
    {
        public DrivingCompensation(string title) : base(title)
        {
        }

        public void AddExpense(DrivingExpense expense)
        {
            AddExpense(expense as Expense.Expense);
        }
    }
}
