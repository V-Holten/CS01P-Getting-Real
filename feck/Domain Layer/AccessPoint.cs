using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class AccessPoint
    {
        internal readonly Employee employee;

        /// <summary>
        /// Gives access to the modules which requires an account
        /// </summary>
        /// <param name="employeeId"></param>
        public AccessPoint(int employeeId)
        {
            employee = Employee.GetEmployee(employeeId);
        }

        public int Id => employee.Id;
        public string Fullname => employee.Fullname;
        public Department Department => employee.Department;
    }
}
