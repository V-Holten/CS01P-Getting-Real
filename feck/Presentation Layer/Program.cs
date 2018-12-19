using Domain_Layer;
using Domain_Layer.Expense;
using Persistence_Layer;
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
            int employeeId = Request.Int("Hvad er dit medarbejder ID?");

            try
            {
                Persistence_Layer.Employee employee = Persistence_Layer.Employee.GetEmployee(employeeId);
                Console.WriteLine(employee.Fullname);
                try
                {
                    Persistence_Layer.Department department = employee.Department;
                    Console.WriteLine(department.Id);
                }
                catch (EntryPointNotFoundException)
                {
                    Console.WriteLine("Kunne ikke finde afdelingen!");
                }
            }
            catch (EntryPointNotFoundException)
            {
                Console.WriteLine("Kunne ikke finde data for medarbejder ID " + employeeId);
            }
            Console.ReadKey();

            //Department department = new Department("302");

            //SmartMenu smartMenu = new SmartMenu("Afdeling " + department.Title, "Luk programmet");

            //smartMenu.Attach(new ShowAllCompensations(department));

            //smartMenu.Attach(new CreateDriving(department));

            //smartMenu.Attach(new CreateTravel(department));

            //smartMenu.Activate();
        }
    }
}
