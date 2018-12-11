using Domain_Layer.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    public class TravelCompensation : Compensation
    {
        public TravelCompensation(int id, DateTime date, Employee employee, string title) : base(id, date, employee, title)
        {
        }
    }
}
