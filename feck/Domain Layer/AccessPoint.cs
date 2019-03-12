using Domain_Layer.Compensations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class AccessPoint
    {
        public readonly Employee Employee;

        private static AccessPoint instance;

        public static AccessPoint Instance
        {
            get
            {
                return instance;
            }
        }

        private AccessPoint(int employeeId)
        {
            Employee = Employee.GetEmployeeById(employeeId);
        }

        public static void AssignSingleton(int employeeId)
        {
            instance = new AccessPoint(employeeId);
        }

        public Department Department => Employee.Department;

        public List<Compensation> GetAllCompensations()
        {
            return Employee.GetCompensations();
        }
    }
}
