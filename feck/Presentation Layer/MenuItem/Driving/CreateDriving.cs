using Domain_Layer;
using Domain_Layer.Compensations;
using Presentation_Layer.MenuItem;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class CreateDriving : IMenuItem
    {
        public bool Activate(SmartMenu smartMenu)
        {
            string title = Request.String("Kørsels godtgørelse titel");
            string numberPlate = Request.String("Nummerplade");
            Driving drivingCompensation = new Driving(title, AccessPoint.Instance.Employee, numberPlate);

            SmartMenu sm = new SmartMenu(drivingCompensation.Title, "Anullér");

            sm.Attach(new AddTrip(drivingCompensation));

            sm.Attach(new AddCompensationToDepartment(AccessPoint.Instance.Department, drivingCompensation));
            
            sm.Activate();
            
            return false;
        }

        public override string ToString()
        {
            return "Opret kørsels godtgørelse";
        }
    }
}
