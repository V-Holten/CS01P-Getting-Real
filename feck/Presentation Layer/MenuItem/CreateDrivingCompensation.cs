using Domain_Layer;
using Domain_Layer.Compensation;
using Presentation_Layer.MenuItem;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class CreateDrivingCompensation : IMenuItem
    {
        private Department Department;

        public CreateDrivingCompensation(Department department)
        {
            Department = department;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string title = SmartMenu.RequestString("Kørsels godtgørelse titel");
            DrivingCompensation drivingCompensation = new DrivingCompensation(title, DateTime.Now);

            SmartMenu sm = new SmartMenu(drivingCompensation.Title, "Anullér", drivingCompensation.Date.ToString());

            sm.Add(new AddDrivingExpense(drivingCompensation));

            sm.Add(new AddCompensation(Department, drivingCompensation));

            
            sm.Activate();


            
            return false;
        }

        public override string ToString()
        {
            return "Opret kørsels godtgørelse";
        }
    }
}
