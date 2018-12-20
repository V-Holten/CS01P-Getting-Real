using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Appendices
{
    public class Trip : Appendix
    {
        public readonly string DepartureDestination;
        public readonly DateTime DepartureDate;
        public readonly string ArrivalDestination;
        public readonly DateTime ArrivalDate;
        public readonly int Distance;
        public readonly int driving;

        internal Trip(int id, string title, string departureDestination, DateTime departureDate, string arrivalDestination, DateTime arrivalDate, int distance, int driving) : base(id, title)
        {
            DepartureDestination = departureDestination;
            DepartureDate = departureDate;
            ArrivalDestination = arrivalDestination;
            ArrivalDate = arrivalDate;
            Distance = distance;
            this.driving = driving;
        }

        public Trip(string title, string departureDestination, DateTime departureDate, string arrivalDestination, DateTime arrivalDate, int distance) : base(title)
        {
            DepartureDestination = departureDestination;
            DepartureDate = departureDate;
            ArrivalDestination = arrivalDestination;
            ArrivalDate = arrivalDate;
            Distance = distance;
        }
    }
}
