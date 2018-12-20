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
    public class Driving : Compensation
    {
        public readonly string NumberPlate;

        public Driving(string title, AccessPoint accessPoint, string numberPlate) : base(title, accessPoint.employee)
        {
            NumberPlate = numberPlate;
        }

        public void AddExpense(Trip expense)
        {
            AddExpense(expense as Appendix);
        }

        public override void Save()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("insert_driving_compensation", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@title", Title);
                command.Parameters.AddWithValue("@employee", Employee.Id);
                command.Parameters.AddWithValue("@numberplate", NumberPlate);

                command.ExecuteNonQuery();
            }
            Appendix.ForEach(o => o.Save());
        }
    }
}
