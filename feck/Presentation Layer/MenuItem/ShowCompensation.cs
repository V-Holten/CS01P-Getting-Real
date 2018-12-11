using Domain_Layer.Compensation;
using Domain_Layer.Expense;
using Presentation_Layer.MenuItem;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class ShowCompensation : IMenuItem
    {
        private Compensation Compensation;

        public ShowCompensation(Compensation compensation)
        {
            Compensation = compensation;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string description = string.Format(
                "{0}",
                Compensation.Date
            );

            SmartMenu sm = new SmartMenu(ToString(), "Tilbage", description);

            foreach (Expense expense in Compensation.GetExpenses())
            {
                sm.Add(new ShowExpense(expense));
            }

            sm.Activate();

            return false;
        }

        public override string ToString() => Compensation.Title;
    }
}
