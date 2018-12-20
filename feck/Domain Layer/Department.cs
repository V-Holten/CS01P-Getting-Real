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
    public class Department
    {
        private List<Compensation> Compensations = new List<Compensation>();
        public readonly int Id;

        public Department(int id)
        {
            Id = id;
        }

        public void AddCompensation(Compensation compensation)
        {
            compensation.Save();
            Compensations.Add(compensation);
        }

        public void RemoveCompensation(Compensation compensation)
        {
            Compensations.Remove(compensation);
        }

        public IList<Compensation> GetAllCompensations()
        {
            return Compensations.AsReadOnly();
        }
    }
}
