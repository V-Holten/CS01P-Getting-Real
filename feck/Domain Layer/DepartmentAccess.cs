using Persistence_Layer;
using Persistence_Layer.Compensations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class DepartmentAccess
    {
        private readonly Department department;

        public DepartmentAccess(AccessPoint access)
        {
            department = access.employee.Department;
        }

        public List<CompensationAccess> GetAllCompensations()
        {
            List<CompensationAccess> compensations = new List<CompensationAccess>();
            foreach (Compensation compensation in department.GetAllCompensations())
            {
                compensations.Add(new CompensationAccess(compensation));
            }
            return compensations;
        }
    }
}
