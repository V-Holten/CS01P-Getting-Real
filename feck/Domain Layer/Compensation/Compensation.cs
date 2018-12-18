using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer.Expense;

namespace Domain_Layer.Compensation
{
    public abstract class Compensation
    {
        protected List<Expense.Appendix> Expenses = new List<Expense.Appendix>();

        protected Compensation(string title)
        {
            Title = title;
        }
        
        public string Title { get; private set; }

        protected void AddExpense(Expense.Appendix expense)
        {
            Expenses.Add(expense);
        }

        public void RemoveExpense(Expense.Appendix expense)
        {
            Expenses.Remove(expense);
        }

        public IList<Expense.Appendix> GetExpenses()
        {
            return Expenses.AsReadOnly();
        }

        public int CountExpenses()
        {
            return Expenses.Count;
        }
    }
}
