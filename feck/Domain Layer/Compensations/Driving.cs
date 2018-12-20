using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer.Appendices;

namespace Domain_Layer.Compensations
{
    public class Driving : Compensation
    {
        private List<Trip> Trips = new List<Trip>();
        public readonly string NumberPlate;

        internal Driving(int id, string title, int employee, string numberPlate) : base(id, title, employee)
        {
            NumberPlate = numberPlate;
        }

        public Driving(string title, int employee, string numberPlate) : base(title, employee)
        {
            NumberPlate = numberPlate;
        }

        internal List<Driving> GetAllDriving()
        {
            throw new NotImplementedException();
        }

        public void AddExpense(Trip trip)
        {
            Trips.Add(trip);
        }
    }
}
