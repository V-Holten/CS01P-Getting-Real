using Domain_Layer.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    class TravelCompensation : Compensation
    {
        public List<TravelExpense> TravelExpense;

        public TravelCompensation(int cpid, DateTime date, Employee employee) : base(cpid, date, employee)
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
