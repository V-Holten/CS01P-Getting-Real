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

        public DrivingCompensation(int cpid, DateTime date, Employee employee, string title) : base(cpid, date, employee, title)
        {
        }

        public override void CreateExpense(string title, DateTime date, string description, int amount)
        {
            throw new NotImplementedException();
            //DrivingExpenses.Add(new DrivingExpense(title, description));
        }

        public override void DeleteExpense(int id)
        {
            foreach (DrivingExpense item in DrivingExpenses)
            {
                throw new NotImplementedException();
                //if (item.Id == id)
                //{
                //    DrivingExpenses.Remove(item);
                //    return;
                //}
            }
        }
    }
}
