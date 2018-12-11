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
        private Department Department;

        public ShowAllCompensations(Department department)
        {
            Department = department;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            IList<Compensation> compensations = Department.GetAllCompensations();

            SmartMenu sm = new SmartMenu("Alle godtgørelser", "Tilbage");

            foreach (Compensation compensation in compensations)
            {
                sm.Add(new ShowCompensation(compensation));
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
