using Domain_Layer.Appendices;
using Domain_Layer.Compensations;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer.MenuItem
{
    class EditTrip : IMenuItem
    {
        private Compensation Compensation;
        private Trip trip;
        
        public EditTrip(Compensation compensation, Trip trip)
        {
            Compensation = compensation;
            this.trip = trip;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string description = string.Format(
                "{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                trip.Title,
                trip.DepartureDestination,
                trip.DepartureDate,
                trip.ArrivalDestination,
                trip.ArrivalDate,
                trip.Distance
            );

            SmartMenu sm = new SmartMenu(trip.Title, "Tilbage", description);

            sm.Attach(new RemoveExpense(Compensation, trip));


            int countExpenses = Compensation.GetExpenses().Count;

            sm.Activate();

            if (countExpenses > Compensation.GetExpenses().Count)
            {
                smartMenu.Detach(this);
            }

            return false;
        }

        public override string ToString() => string.Format("Se {0}", trip.Title);
    }
}
