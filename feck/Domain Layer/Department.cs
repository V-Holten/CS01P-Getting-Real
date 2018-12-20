using Domain_Layer.Compensations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class Department : Entry
    {
        public readonly int Id;

        internal Department(int id)
        {
            Id = id;
        }

        internal static Department GetDepartment(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetDepartmentById", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", id));

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    return new Department(id);
                }
                else
                {
                    throw new EntryPointNotFoundException();
                }
            }
        }

        public List<Compensation> GetAllCompensations()
        {
            throw new NotImplementedException();
        }
    }
}
