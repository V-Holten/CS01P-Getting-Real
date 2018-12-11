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
        private Expense Expense;

        public ShowExpense(Expense expense)
        {
            Expense = expense;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string description;
            if (Expense is DrivingExpense)
            {
                DrivingExpense drivingExpense = Expense as DrivingExpense;
                description = string.Format(
                    "{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                    drivingExpense.Description,
                    drivingExpense.DepartureDestination,
                    drivingExpense.DepartureDate,
                    drivingExpense.ArrivalDestination,
                    drivingExpense.ArrivalDate,
                    drivingExpense.Distance
                );
            }
            else
            {
                description = string.Format(
                    "{0}",
                    Expense.Description
                );
            }

            SmartMenu sm = new SmartMenu(ToString(), "Tilbage", description);

            sm.Activate();

            return false;
        }

        public override string ToString() => string.Format("Afregning: {0}", Expense.Title);
    }
}
