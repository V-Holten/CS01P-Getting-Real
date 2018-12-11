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
        private List<Expense.Expense> Expenses = new List<Expense.Expense>();

        protected Compensation(string title, DateTime date)
        {
            Title = title;
            Date = date;
        }
        
        public string Title { get; private set; }
        public DateTime Date { get; private set; }

        protected void AddExpense(Expense.Expense expense)
        {
            Expenses.Add(expense);
        }

        public void RemoveExpense(Expense.Expense expense)
        {
            Expenses.Remove(expense);
        }

        public IList<Expense.Expense> GetExpenses()
        {
            return Expenses.AsReadOnly();
        }

        public int CountExpenses()
        {
            return Expenses.Count;
        }
    }
}
