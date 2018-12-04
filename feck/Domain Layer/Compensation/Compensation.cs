using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    abstract class Compensation
    {
        public int Id;
        public string Title;
        public DateTime Date;
        public Employee Employee;

        public Compensation(int cpid, DateTime date, Employee employee)
        {
            Id = cpid;
            Date = date;
            Employee = employee;
        }

        public abstract void CreateExpense(string title, DateTime date, string description, int amount);

        public abstract void DeleteExpense(int id);
    }
}
