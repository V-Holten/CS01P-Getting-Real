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
        private string Title;
        private Employee Boss;
        private List<Compensation.Compensation> Compensations;

        public void GetAllCompensations()
        {
            string result = "Godtgørelser";
            foreach (Compensation.Compensation item in Compensations)
            {
                result += item.ToString() + "\n";
            }
        }

        public void CreateExpense(int stId, string description, int amount)
        {
            throw new NotImplementedException();
        }

        public void DeleteExpense(int exId, int stId)
        {
            throw new NotImplementedException();
        }

        public void CreateTravelCompensation(int id, DateTime date, Employee employee)
        {
            Compensations.Add(new TravelCompensation(id, date, employee));
        }

        public void CreateDrivingCompensation(int id, DateTime date, Employee employee)
        {
            Compensations.Add(new DrivingCompensation(id, date, employee));
        }
    }
}
