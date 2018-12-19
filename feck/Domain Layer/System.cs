using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class System
    {
        public System(int employeeid)
        {
            Persistence_Layer.Employee.GetEmployee(employeeid);
        }
    }
}
