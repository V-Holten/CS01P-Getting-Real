using Domain_Layer.Compensation;
using Domain_Layer.Expense;
using SmartMenuLibrary;
using System;

namespace Presentation_Layer
{
    internal class AddExpenditure : IMenuItem
    {
        private readonly Travel Travel;

        public AddExpenditure(Travel travel)
        {
            Travel = travel;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string title = Request.String("Titel på udgiften");
            string description = Request.String("Beskrivelse på udgiften");
            DateTime date = Request.DateTime("Tidspunkt");
            double amount = Request.Double(string.Format("Sum af udgiften {0}", title));
            Expenditure.Type type = Request.Enum<Expenditure.Type>("Type");
            bool cash = Request.Bool("Betalte du med kontant?");

            Expenditure expenditure = new Expenditure(title, description, date, amount, type, cash);
            Travel.AddExpense(expenditure);

            smartMenu.Attach(new EditExpenditure(Travel, expenditure));

            return false;
        }

        public override string ToString() => "Tilføj ny bekostning";
    }
}