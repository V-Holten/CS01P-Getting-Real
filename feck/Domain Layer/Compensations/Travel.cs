using Domain_Layer.Appendices;
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
        public readonly double Credit;

        public Travel(string title, AccessPoint accessPoint, DateTime departureDate, DateTime returnDate, bool overNightStay, double credit) : base(title, accessPoint.employee)
        {
            DepartureDate = departureDate;
            ReturnDate = returnDate;
            OverNightStay = overNightStay;
            Credit = credit;
        }

        public void AddExpense(Expenditure expense)
        {
            AddExpense(expense as Appendices.Appendix);
        }

        public override void Save()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("insert_travel_compensation", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@title", Title);
                command.Parameters.AddWithValue("@employee", Employee.Id);
                command.Parameters.AddWithValue("@departuredate", DepartureDate);
                command.Parameters.AddWithValue("@returndate", ReturnDate);
                command.Parameters.AddWithValue("@overnightstay", OverNightStay);
                command.Parameters.AddWithValue("@credit", Credit);

                command.ExecuteNonQuery();
            }
            Appendix.ForEach(o => o.Save());
        }

        public int TimeSpent()
        {
            return (int) Math.Floor((DepartureDate - ReturnDate).TotalHours);
        }

        public double TotalReturn()
        {
            double spent = 0;
            foreach (Expenditure item in Appendix)
            {
                if (item.Cash == true)
                {
                    spent += item.Amount;
                }
            }
            return Credit - spent;
        }
    }
}
