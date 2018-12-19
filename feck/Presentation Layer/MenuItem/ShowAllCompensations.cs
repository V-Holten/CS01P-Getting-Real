using Domain_Layer;
using Domain_Layer.Compensation;
using Presentation_Layer;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class ShowAllCompensations : IMenuItem
    {
        private DepartmentAccess Department;

        public ShowAllCompensations(DepartmentAccess department)
        {
            Department = department;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            IList<CompensationAccess> compensations = Department.GetAllCompensations();

            SmartMenu sm = new SmartMenu("Alle godtgørelser", "Tilbage");

            foreach (CompensationAccess compensation in compensations)
            {
                sm.Attach(new ShowCompensation(compensation));
            }

            sm.Activate();

            return false;
        }

        public override string ToString()
        {
            return "Vis alle godtgørelser";
        }
    }
}
