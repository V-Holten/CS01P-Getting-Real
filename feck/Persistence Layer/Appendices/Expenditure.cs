using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence_Layer.Appendices
{
    public class Expenditure : Appendix
    {
        public readonly Type ExpenseType;
        public readonly bool Cash;
        public readonly DateTime Date;
        public readonly double Amount;
        private readonly int travel;

        public enum Type
        {
            Messeomkostninger = 54080,
            Transport = 87020,
            Ophold = 87030,
            Fortæring = 87040,
            Diverse = 87050,
            Repræsentaion = 81020,
            Bankkortgebyr = 96440
        }

        public Expenditure(int id, string title, Type expenseType, bool cash, DateTime date, double amount, int travel) : base(id, title)
        {
            ExpenseType = expenseType;
            Cash = cash;
            Date = date;
            Amount = amount;
            this.travel = travel;
        }
    }
}
