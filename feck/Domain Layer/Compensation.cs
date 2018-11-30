using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    class Compensation
    {
        private int Id;
        private string Title;
        private DateTime Date;
        private List<Expense> Expenses;
        private Employee Employee;

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
