using Domain_Layer.Compensation;
using Domain_Layer.Expense;
using Presentation_Layer.MenuItem;
using SmartMenuLibrary;

namespace Presentation_Layer
{
    internal class EditExpenditure : IMenuItem
    {
        private Compensation Compensation;
        private Expenditure Expenditure;

        public EditExpenditure(Compensation travel, Expenditure expenditure)
        {
            Compensation = travel;
            Expenditure = expenditure;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string description = string.Format(
                "{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                Expenditure.Title,
                Expenditure.Description,
                Expenditure.Date,
                Expenditure.Amount,
                Expenditure.ExpenseType,
                Expenditure.Cash
            );

            SmartMenu sm = new SmartMenu(Expenditure.Title, "Tilbage", description);

            sm.Attach(new RemoveExpense(Compensation, Expenditure));
            
            int countExpenses = Compensation.CountExpenses();

            sm.Activate();

            if (countExpenses > Compensation.CountExpenses())
            {
                smartMenu.Detach(this);
            }

            return false;
        }

        public override string ToString() => string.Format("Se {0}", Compensation.Title);
    }
}