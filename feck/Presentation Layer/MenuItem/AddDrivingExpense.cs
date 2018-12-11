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
    class AddDrivingExpense : IMenuItem
    {
        private DrivingCompensation DrivingCompensation;

        public AddDrivingExpense(DrivingCompensation drivingCompensation)
        {
            DrivingCompensation = drivingCompensation;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string title =  SmartMenu.RequestString("Titel på bekostningen");
            string description = SmartMenu.RequestString("Beskrivelse på bekostningen");
            string departureDestination = SmartMenu.RequestString("Hvor kørte du fra?");
            DateTime departureDate = SmartMenu.RequestDateTime(string.Format("Hvornår kørte du fra {0}?", departureDestination));
            string arrivalDestination = SmartMenu.RequestString("Hvor kørte du til?");
            DateTime arrivalDate = SmartMenu.RequestDateTime(string.Format("Hvornår kom du til {0}?", arrivalDestination));
            int distance = SmartMenu.RequestInt("Hvor mange kilometer (i hele tal)?");

            DrivingExpense drivingExpense = new DrivingExpense(title, description, departureDestination, departureDate, arrivalDestination, arrivalDate, distance);
            DrivingCompensation.AddExpense(drivingExpense);

            smartMenu.Add(new EditDrivingExpense(DrivingCompensation, drivingExpense));

            return false;
        }

        public override string ToString() => "Tilføj ny bekostning";
    }
}
