using Domain_Layer;
using SmartMenu;
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

        public bool Activate()
        {
            Console.Clear();
            Console.WriteLine("Angiv en titlen på den kørsels godtgørelsen, du ønsker at oprette");
            Department.CreateDrivingCompensation(Department.GetNumberOfCompensations(), DateTime.Now, new Employee(), Console.ReadLine());
            Console.WriteLine("Kørsels godtgørlse er blevet oprettet");
            Console.ReadKey();
            return false;
        }

        public string ToSmartMenu()
        {
            return "Opret kørsels godtgørelse";
        }
    }
}
