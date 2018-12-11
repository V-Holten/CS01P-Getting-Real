using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    public abstract class Compensation
    {
        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public DateTime Date { get; protected set; }
        public Employee Employee { get; protected set; }
        protected List<Expense.Expense> Expenses = new List<Expense.Expense>();

        public Compensation(int id, DateTime date, Employee employee, string title)
        {
            Id = id;
            Date = date;
            Employee = employee;
            Title = title;
        }

        public void AddExpense(Expense.Expense expense)
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
    }
}
