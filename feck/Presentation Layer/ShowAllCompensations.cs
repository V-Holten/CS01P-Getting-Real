using Domain_Layer;
using Domain_Layer.Compensation;
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
            IList<Compensation> compensations = Department.GetAllCompensations();
            Console.WriteLine("Godtgørelser");
            foreach (Compensation item in compensations)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }

        public string ToSmartMenu()
        {
            return "Vis alle godtgørelser";
        }
    }
}
