using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    class Department
    {
        private int Id;
        private string Title;
        private Employee Boss;
        private List<Compensation> Compensations;

        private void CreateExpense(int stId, string description, int amount)
        {
            throw new NotImplementedException();
        }

        private void DeleteExpense(int exId, int stId)
        {
            throw new NotImplementedException();
        }

        private void CreateCompensation(int id, DateTime date, Employee employee)
        {
            Compensations.Add(new Compensation(id, date, employee));
        }
    }
}
