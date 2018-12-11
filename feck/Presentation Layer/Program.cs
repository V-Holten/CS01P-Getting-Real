using Domain_Layer;
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
            Department department = new Department();

            SmartMenu smartMenu = new SmartMenu("Velkommen!", "Luk programmet");

            smartMenu.Add(new ShowAllCompensations(department));

            smartMenu.Add(new CreateTravelCompensation(department));

            smartMenu.Add(new CreateDrivingCompensation(department));

            smartMenu.Activate();
        }
    }
}
