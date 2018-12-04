using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    class Compensation
    {
        private int CompensationId;
        private string Title;
        private DateTime Date;
        private List<Expense> Expenses;
        private Employee Employee;

        public Compensation(int cpId, DateTime date, Employee employee)
        {
            CompensationId = cpId;
            Date = date;
            Employee = employee;
        }

        private void CreateExpense(DateTime date, string description, int amount)
        {
            throw new NotImplementedException();
        }

        private void DeleteExpense(int exId)
        {
            throw new NotImplementedException();
        }
    }
}
