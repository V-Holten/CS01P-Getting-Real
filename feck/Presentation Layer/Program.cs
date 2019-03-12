using Domain_Layer;
using Domain_Layer.Appendices;
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
            do
            {
                int employeeId = Request.Int("Hvad er dit medarbejder ID?");
                try
                {
                    AccessPoint.AssignSingleton(employeeId);
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
            } while (AccessPoint.Instance is null);

            Department department = AccessPoint.Instance.Department;

            SmartMenu smartMenu = new SmartMenu("Afdeling " + department.Id, "Luk programmet");

            smartMenu.Attach(new ShowAllCompensations());

            smartMenu.Attach(new CreateDriving());

            smartMenu.Attach(new CreateTravel());

            smartMenu.Activate();
        }
    }
}
