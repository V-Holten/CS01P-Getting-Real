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
        public List<DrivingExpense> DrivingExpenses;

        public DrivingCompensation(int cpid, DateTime date, Employee employee) : base(cpid, date, employee)
        {
        }

        public override void CreateExpense(string title, DateTime date, string description, int amount)
        {
            DrivingExpenses.Add(new DrivingExpense(title, date, description, amount));
        }

        public override void DeleteExpense(string title)
        {
            foreach (DrivingExpense item in DrivingExpenses)
            {
                if (item.Title.Equals(title))
                {
                    DrivingExpenses.Remove(item);
                    return;
                }
            }
        }
    }
}
