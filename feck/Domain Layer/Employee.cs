using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class Employee
    {
        private readonly string Fullname;
        private readonly string Email;
        private readonly Department Department;
        private readonly int PaymentRegistationNumber;
        private readonly int PaymentAccountNumber;
        private readonly string LicensePlate;

        public Employee(string fullname, string email, Department department, int paymentRegistationNumber, int paymentAccountNumber, string licensePlate)
        {
            Fullname = fullname;
            Email = email;
            Department = department;
            PaymentRegistationNumber = paymentRegistationNumber;
            PaymentAccountNumber = paymentAccountNumber;
            LicensePlate = licensePlate;
        }
    }
}
