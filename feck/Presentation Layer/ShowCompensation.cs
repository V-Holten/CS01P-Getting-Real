using Domain_Layer.Compensation;
using SmartMenu;
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

        public void Activate()
        {
            Console.Clear();
            Console.WriteLine("Du har valgt " + Compensation.Title);
            Console.ReadKey();
        }

        public string ToSmartMenu()
        {
            return Compensation.Title;
        }
    }
}
