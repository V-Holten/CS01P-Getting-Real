using SmartMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer;

namespace Presentation_Layer
{
    class CreateTravelCompensation : IMenuItem
    {
        private Department Department;

        public CreateTravelCompensation(Department department)
        {
            Department = department;
        }

        public void Activate()
        {
            Console.Clear();
            Console.WriteLine("Angiv en titlen på den rejse godtgørelsen, du ønsker at oprette");
            Department.CreateTravelCompensation(Department.GetNumberOfCompensations(), DateTime.Now, new Employee(), Console.ReadLine());
            Console.WriteLine("Rejse godtgørelsen er blevet oprettet");
        }

        public string ToSmartMenu()
        {
            return "Opret rejse godtgørelse";
        }
    }
}
