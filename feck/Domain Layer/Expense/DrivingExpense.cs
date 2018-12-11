using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public class DrivingExpense : Expense
    {
        public readonly double Rate = 3.54;

        public DrivingExpense(string title, string description, string departureDestination, DateTime departureDate, string arrivalDestination, DateTime arrivalDate, int distance) : base(title, description)
        {
            DepartureDestination = departureDestination;
            DepartureDate = departureDate;
            ArrivalDestination = arrivalDestination;
            ArrivalDate = arrivalDate;
            Distance = distance;
        }

        public string DepartureDestination { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public string ArrivalDestination { get; private set; }
        public DateTime ArrivalDate { get; private set; }
        public int Distance { get; private set; }
    }
}
