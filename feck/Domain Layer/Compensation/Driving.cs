using Domain_Layer.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    public class Driving : Compensation
    {
        public Driving(string title) : base(title)
        {
        }

        public void AddExpense(Trip expense)
        {
            AddExpense(expense as Expense.Appendix);
        }
    }
}
