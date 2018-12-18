using Domain_Layer.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensation
{
    public class Travel : Compensation
    {
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool OverNightStay { get; set; }
        public double Credit { get; set; }

        public Travel(string title, DateTime departureDate, DateTime returnDate, bool overNightStay) : base(title)
        {
            DepartureDate = departureDate;
            ReturnDate = returnDate;
            OverNightStay = overNightStay;
        }

        public void AddExpense(Expenditure expense)
        {
            AddExpense(expense as Expense.Appendix);
        }

        public int TimeSpent()
        {
            return (int) Math.Floor((DepartureDate - ReturnDate).TotalHours);
        }

        public double TotalReturn()
        {
            double spent = 0;
            foreach (Expenditure item in Expenses)
            {
                if (item.Cash == true)
                {
                    spent += item.Amount;
                }
            }
            return Credit - spent;
        }
    }
}
