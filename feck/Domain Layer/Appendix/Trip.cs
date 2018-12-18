using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public class Trip : Appendix
    {
        public readonly double Rate = 3.54;
        public readonly string DepartureDestination;
        public readonly DateTime DepartureDate;
        public readonly string ArrivalDestination;
        public readonly DateTime ArrivalDate;
        public readonly int Distance;

        public Trip(string title, string description, string departureDestination, DateTime departureDate, string arrivalDestination, DateTime arrivalDate, int distance) : base(title, description)
        {
            DepartureDestination = departureDestination;
            DepartureDate = departureDate;
            ArrivalDestination = arrivalDestination;
            ArrivalDate = arrivalDate;
            Distance = distance;
        }
    }
}
