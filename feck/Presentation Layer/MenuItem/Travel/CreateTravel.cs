using Domain_Layer;
using Domain_Layer.Compensations;
using Presentation_Layer.MenuItem;
using SmartMenuLibrary;
using System;

namespace Presentation_Layer
{
    internal class CreateTravel : IMenuItem
    {
        public bool Activate(SmartMenu smartMenu)
        {
            string title = Request.String("Rejse godtgørelsens titel:");
            DateTime departureDate = Request.DateTime("Hvornår tog du afsted?");
            DateTime returnDate = Request.DateTime("Hvorn år kom du hjem?");
            bool overNightStay = Request.Bool("Overnattede du under rejsen?");
            double credit = Request.Double("Hvor meget i kontant havde du med?");
            Travel travel = new Travel(title, AccessPoint.Instance.Employee, departureDate, returnDate, overNightStay, credit);

            SmartMenu sm = new SmartMenu(travel.Title, "Anullér");

            sm.Attach(new AddExpenditure(travel));

            sm.Attach(new AddCompensationToDepartment(AccessPoint.Instance.Department, travel));

            sm.Activate();

            return false;
        }

        public override string ToString()
        {
            return "Opret rejse godtgørelse";
        }
    }
}