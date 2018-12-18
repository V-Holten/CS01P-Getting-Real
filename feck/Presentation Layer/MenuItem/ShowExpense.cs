using Domain_Layer.Expense;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer.MenuItem
{
    class ShowExpense : IMenuItem
    {
        private Appendix Expense;

        public ShowExpense(Appendix expense)
        {
            Expense = expense;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string description;
            if (Expense is Trip)
            {
                Trip trip = Expense as Trip;
                description = string.Format(
                    "{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                    trip.Description,
                    trip.DepartureDestination,
                    trip.DepartureDate,
                    trip.ArrivalDestination,
                    trip.ArrivalDate,
                    trip.Distance
                );
            }
            else
            {
                Expenditure trip = Expense as Expenditure;
                description = string.Format(
                    "{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                    trip.Title,
                    trip.Description,
                    trip.Date,
                    trip.Amount,
                    trip.ExpenseType,
                    trip.Cash
                );
            }

            SmartMenu sm = new SmartMenu(ToString(), "Tilbage", description);

            sm.Activate();

            return false;
        }

        public override string ToString() => string.Format("Afregning: {0}", Expense.Title);
    }
}
