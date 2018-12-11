using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer.Compensation;

namespace Domain_Layer
{
    public class Department
    {
        private List<Compensation.Compensation> Compensations = new List<Compensation.Compensation>();

        public Department(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }

        public void AddCompensation(Compensation.Compensation compensation)
        {
            Compensations.Add(compensation);
        }

        public void RemoveCompensation(Compensation.Compensation compensation)
        {
            Compensations.Remove(compensation);
        }

        public IList<Compensation.Compensation> GetAllCompensations()
        {
            return Compensations.AsReadOnly();
        }
    }
}
