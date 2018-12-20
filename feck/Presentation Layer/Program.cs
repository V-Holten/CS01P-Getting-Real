using Domain_Layer;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessPoint accessPoint = null;
            do
            {
                int employeeId = Request.Int("Hvad er dit medarbejder ID?");
                try
                {
                    accessPoint = new AccessPoint(employeeId);
                }
                catch (EntryPointNotFoundException)
                {
                    Console.WriteLine("Kunne ikke finde data for medarbejder ID " + employeeId);
                    Console.ReadKey();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Noget gik galt mellem serveren & programmet: " + e);
                    Console.ReadKey();
                }
            } while (accessPoint is null);

            Department department = accessPoint.Department;

            SmartMenu smartMenu = new SmartMenu($"Velkommen, {accessPoint.Fullname}!", "Luk programmet");

            smartMenu.Attach(new ShowAllCompensations(department));

            smartMenu.Attach(new CreateDriving(accessPoint));

            smartMenu.Attach(new CreateTravel(accessPoint));

            smartMenu.Activate();
        }
    }
}
