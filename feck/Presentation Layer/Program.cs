using Domain_Layer;
using SmartMenu;
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

            Binding binding = new Binding();

            binding.Add(new ShowAllCompensations(department));

            binding.Add(new CreateTravelCompensation(department));

            binding.Add(new CreateDrivingCompensation(department));

            SmartMenu.SmartMenu.Activate("Welcome!", binding);
        }
    }
}
