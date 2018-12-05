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
            int i = 1;
            foreach (Compensation item in compensations)
            {
               Console.WriteLine("Nr: " + i + " " + item.ToString());
               i++;
            }
            Console.ReadKey();
        }

        public string ToSmartMenu()
        {
            return "Vis alle godtgørelser";
        }
    }
}
