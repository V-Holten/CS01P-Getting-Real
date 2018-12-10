using Domain_Layer;
using Domain_Layer.Compensation;
using Presentation_Layer;
using SmartMenu;
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

        public void Activate()
        {
            IList<Compensation> compensations = Department.GetAllCompensations();

            Binding binding = new Binding();

            foreach (Compensation compensation in compensations)
            {
                binding.Add(new ShowCompensation(compensation));
            }

            SmartMenu.SmartMenu.Activate("Alle godtgørelser", binding, "Tilbage");
        }

        public string ToSmartMenu()
        {
            return "Vis alle godtgørelser";
        }
    }
}
