using Domain_Layer.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    class DrivingCompensation : Compensation
    {
        public List<DrivingExpense> DrivingExpenses;

        public DrivingCompensation(int cpid, DateTime date, Employee employee) : base(cpid, date, employee)
        {
        }

        public override void CreateExpense(string title, DateTime date, string description, int amount)
        {
            DrivingExpenses.Add(new DrivingExpense(title, date, description, amount));
        }

        public override void DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }
    }
}
