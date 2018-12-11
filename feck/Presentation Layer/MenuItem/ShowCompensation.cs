using Domain_Layer.Compensation;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class ShowCompensation : IMenuItem
    {
        private Compensation Compensation;

        public ShowCompensation(Compensation compensation)
        {
            Compensation = compensation;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            //Binding binding = new Binding();

            //SmartMenu.SmartMenu.Activate(Compensation.Title);
            return false;
        }

        public string ToSmartMenu()
        {
            return Compensation.Title;
        }
    }
}
