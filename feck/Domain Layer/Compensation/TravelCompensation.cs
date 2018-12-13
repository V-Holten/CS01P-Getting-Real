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
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool OverNightStay { get; set; }
        public double Credit { get; set; }

        public TravelCompensation(string title, DateTime departureDate, DateTime returnDate, bool overNightStay) : base(title)
        {
            DepartureDate = departureDate;
            ReturnDate = returnDate;
            OverNightStay = overNightStay;
        }

        public void AddExpense(TravelExpense expense)
        {
            AddExpense(expense as Expense.Expense);
        }

        public int TimeSpent()
        {
            return (int) Math.Floor((DepartureDate - ReturnDate).TotalHours);
        }

        public double TotalReturn()
        {
            double spent = 0;
            foreach (TravelExpense item in Expenses)
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
