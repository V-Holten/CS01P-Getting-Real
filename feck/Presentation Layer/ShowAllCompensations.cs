using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenu
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
            Console.Clear();
            Console.WriteLine(Department.ToString());
            Console.ReadKey();
        }

        public string ToSmartMenu()
        {
            return "Vis alle godtgørelser";
        }
    }
}
