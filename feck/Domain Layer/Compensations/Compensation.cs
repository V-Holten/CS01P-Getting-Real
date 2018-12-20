using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer.Appendices;

namespace Domain_Layer.Compensations
{
    public abstract class Compensation : ISavable
    {
        protected static readonly string ConnectionString = "Server=EALSQL1.eal.local; Database=B_DB17_2018; User Id=B_STUDENT17; Password=B_OPENDB17;";
        public int Id { get; internal set; }
        protected List<Appendix> Appendix = new List<Appendix>();
        public readonly string Title;
        internal readonly Employee Employee;

        protected Compensation(string title, Employee employee)
        {
            Title = title;
            Employee = employee;
        }

        protected void AddExpense(Appendix expense)
        {
            Appendix.Add(expense);
        }

        public void RemoveExpense(Appendix expense)
        {
            Appendix.Remove(expense);
        }

        public abstract List<Appendix> GetExpenses();

        public int CountExpenses()
        {
            return Appendix.Count;
        }

        public abstract void Save();
    }
}
