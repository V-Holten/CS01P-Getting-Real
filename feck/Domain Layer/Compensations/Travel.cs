using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Compensations
{
    public class Travel : Compensation
    {
        public readonly DateTime DepartureDate;
        public readonly DateTime ReturnDate;
        public readonly bool OverNightStay;

        internal Travel(int id, string title, int employee, DateTime departureDate, DateTime returnDate, bool overNightStay) : base(id, title, employee)
        {
            DepartureDate = departureDate;
            ReturnDate = returnDate;
            OverNightStay = overNightStay;
        }

        public Travel(string title, int employee, DateTime departureDate, DateTime returnDate, bool overNightStay) : base(title, employee)
        {
            DepartureDate = departureDate;
            ReturnDate = returnDate;
            OverNightStay = overNightStay;
        }

        internal List<Travel> GetAllTravel()
        {
            List<Travel> Travels = new List<Travel>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetAll", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string title = reader["title"].ToString();
                        int employee = int.Parse(reader["id"].ToString());
                        DateTime departureDate = DateTime.Parse(reader["departuredate"].ToString());
                        DateTime returnDate = DateTime.Parse(reader["returndate"].ToString());
                        bool overNightStay = bool.Parse(reader["overnightstay"].ToString());
                        Travels.Add(new Travel(id, title, employee, departureDate, returnDate, overNightStay));
                    }
                }
            }
            return Travels;
        }
    }
}
