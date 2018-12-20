using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence_Layer.Compensations
{
    public class Travel : Compensation
    {
        public readonly DateTime DepartureDate;
        public readonly DateTime ReturnDate;
        public readonly bool OverNightStay;

        private Travel(int id, string title, int employee, DateTime departureDate, DateTime returnDate, bool overNightStay) : base(id, title, employee)
        {
            DepartureDate = departureDate;
            ReturnDate = returnDate;
            OverNightStay = overNightStay;
        }
    }
}
