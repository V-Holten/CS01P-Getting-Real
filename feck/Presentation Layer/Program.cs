using Domain_Layer;
using Domain_Layer.Expense;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            Department department = new Department("302");

            SmartMenu smartMenu = new SmartMenu("Afdeling " + department.Title, "Luk programmet");

            smartMenu.Add(new ShowAllCompensations(department));

            smartMenu.Add(new CreateDrivingCompensation(department));

            smartMenu.Add(new CreateTravel(department));

            smartMenu.Activate();
        }
    }
}
