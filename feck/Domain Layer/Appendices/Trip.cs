using Domain_Layer.Compensations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Appendices
{
    public class Trip : Appendix
    {
        public readonly double Rate = 3.54;

        public readonly string DepartureDestination;
        public readonly DateTime DepartureDate;
        public readonly string ArrivalDestination;
        public readonly DateTime ArrivalDate;
        public readonly int Distance;
        private readonly Driving driving;

        public Trip(string title, string departureDestination, DateTime departureDate, string arrivalDestination, DateTime arrivalDate, int distance, Driving driving) : base(title)
        {
            DepartureDestination = departureDestination;
            DepartureDate = departureDate;
            ArrivalDestination = arrivalDestination;
            ArrivalDate = arrivalDate;
            Distance = distance;
            this.driving = driving;
        }

        public override void Save()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("insert_driving_compensation", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@title", Title);
                command.Parameters.AddWithValue("@departuredestination", DepartureDestination);
                command.Parameters.AddWithValue("@departuredate", DepartureDate);
                command.Parameters.AddWithValue("@arrivaldestination", ArrivalDestination);
                command.Parameters.AddWithValue("@arrivaldate", ArrivalDate);
                command.Parameters.AddWithValue("@distance", Distance);
                command.Parameters.AddWithValue("@driving", driving.Id);

                command.ExecuteNonQuery();
            }
        }
    }
}
