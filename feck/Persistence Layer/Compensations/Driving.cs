using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence_Layer.Compensations
{
    public class Driving : Compensation
    {
        public readonly string NumberPlate;

        private Driving(int id, string title, int employee, string numberPlate) : base(id, title, employee)
        {
            NumberPlate = numberPlate;
        }
    }
}
