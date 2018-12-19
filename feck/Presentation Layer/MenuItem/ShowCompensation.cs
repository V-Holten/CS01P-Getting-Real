﻿using Domain_Layer;
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
        private CompensationAccess Compensation;

        public ShowCompensation(CompensationAccess compensation)
        {
            Compensation = compensation;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            SmartMenu sm = new SmartMenu(ToString(), "Tilbage");

            foreach (Appendix expense in Compensation.GetExpenses())
            {
                sm.Attach(new ShowExpense(expense));
            }

            sm.Activate();

            return false;
        }

        public override string ToString() => Compensation.Title;
    }
}
