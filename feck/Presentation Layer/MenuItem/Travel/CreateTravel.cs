using Domain_Layer;
using Domain_Layer.Compensation;
using Presentation_Layer.MenuItem;
using SmartMenuLibrary;
using System;

namespace Presentation_Layer
{
    internal class CreateTravel : IMenuItem
    {
        private Department Department;

        public CreateTravel(Department department)
        {
            Department = department;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string title = Request.String("Rejse godtgørelsens titel:");
            DateTime departureDate = Request.DateTime("Hvornår tog du afsted?");
            DateTime returnDate = Request.DateTime("Hvorn år kom du hjem?");
            bool overNightStay = Request.Bool("Overnattede du under rejsen?");
            TravelCompensation travel = new TravelCompensation(title, departureDate, returnDate, overNightStay);

            SmartMenu sm = new SmartMenu(travel.Title, "Anullér");

            sm.Add(new AddExpenditure(travel));

            sm.Add(new AddCompensationToDepartment(Department, travel));

            sm.Activate();

            return false;
        }

        public override string ToString()
        {
            return "Opret rejse godtgørelse";
        }
    }
}