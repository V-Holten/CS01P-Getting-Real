using Domain_Layer.Compensation;
using Domain_Layer.Expense;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer.MenuItem
{
    class RemoveExpense : IMenuItem
    {
        private Compensation Compensation;
        private Expense Expense;

        public RemoveExpense(Compensation compensation, Expense expense)
        {
            Compensation = compensation;
            Expense = expense;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            Compensation.RemoveExpense(Expense);
            smartMenu.Detach(this);
            return true;
        }

        public override string ToString() => string.Format("Fjern {0} fra {1}", Expense.Title, Compensation.Title);
    }
}
