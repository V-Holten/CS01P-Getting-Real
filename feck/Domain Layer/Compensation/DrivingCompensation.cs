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
        public List<DrivingExpense> TravelExpense;

        public DrivingCompensation(int cpid, DateTime date, Employee employee) : base(cpid, date, employee)
        {
        }

        public override void CreateExpense(string title, DateTime date, string Description, int amount)
        {
            throw new NotImplementedException();
        }

        public override void DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }
    }
}
