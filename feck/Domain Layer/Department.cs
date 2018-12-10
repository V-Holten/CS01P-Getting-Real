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
        private int Id;
        public string Title { get; private set; }
        private Employee Boss;
        private List<Compensation.Compensation> Compensations = new List<Compensation.Compensation>();

        public IList<Compensation.Compensation> GetAllCompensations()
        {
            return Compensations.AsReadOnly();            
        }

        public void CreateExpense(int stId, string description, int amount)
        {
            throw new NotImplementedException();
        }

        public void DeleteExpense(int exId, int stId)
        {
            throw new NotImplementedException();
        }

        public void CreateTravelCompensation(int id, DateTime date, Employee employee, string title)
        {
            Compensations.Add(new TravelCompensation(id, date, employee, title));
        }

        public void CreateDrivingCompensation(int id, DateTime date, Employee employee, string title)
        {
            Compensations.Add(new DrivingCompensation(id, date, employee, title));
        }

        // For testing

        public int GetNumberOfCompensations()
        {
            try
            {
                return Compensations.Count;
            }
            catch (NullReferenceException)
            {

                return 0;
            }
        }
    }
}
