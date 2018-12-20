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
        public readonly Employee employee;
           
        public AccessPoint(int employeeId)
        {
            employee = Employee.GetEmployeeById(employeeId);
        }

        public Department Department => employee.Department;

        public List<Compensation> GetAllCompensations()
        {
            return employee.GetCompensations();
        }
    }
}
