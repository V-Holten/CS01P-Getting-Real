using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class Employee
    {
        public readonly int Id;
        public readonly string Fullname;
        public readonly Department Department;

        public Employee(string fullname, string email, Department department, int paymentRegistationNumber, int paymentAccountNumber, string licensePlate)
        {
            Fullname = fullname;
            Department = department;
        }
    }
}
