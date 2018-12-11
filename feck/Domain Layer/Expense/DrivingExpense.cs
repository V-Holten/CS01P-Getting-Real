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

        public string ArrivalDest { get; set; }
        public string DepartureDest { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Distance { get; set; }

        public DrivingExpense(string title, string description, string arrivalDest, string departureDest, int distance)
        {
            Title = title;
            Description = description;
            ArrivalDest = arrivalDest;
            DepartureDest = departureDest;
            Distance = distance;
        }
    }
}
