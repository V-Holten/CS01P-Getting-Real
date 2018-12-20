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
        private AccessPoint accessPoint;

        public CreateDriving(AccessPoint accessPoint)
        {
            this.accessPoint = accessPoint;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            string title = Request.String("Kørsels godtgørelse titel");
            int employee = accessPoint.Id;
            string numberPlate = Request.String("Nummerpladen");
            Driving driving = new Driving(title, employee, numberPlate);

            SmartMenu sm = new SmartMenu(driving.Title, "Anullér");

            sm.Attach(new AddTrip(driving));

            sm.Attach(new AddCompensationToDepartment(accessPoint, driving));
            
            sm.Activate();
            
            return false;
        }

        public override string ToString()
        {
            return "Opret kørsels godtgørelse";
        }
    }
}
