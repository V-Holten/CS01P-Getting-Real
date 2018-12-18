using System;
using System.Collections.Generic;

namespace Persistence_Layer
{
    public class Employee
    {
        private static readonly Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();
        public readonly int EmployeeId;
        public readonly string Fullname;
        public readonly string Email;
        private readonly int DepartmentId;
        public readonly int PaymentRegistationNumber;
        public readonly int PaymentAccountNumber;
        public readonly string LicensePlate;

        private Employee(int employeeId, string fullname, string email, int departmentId, int paymentRegistationNumber, int paymentAccountNumber, string licensePlate)
        {
            EmployeeId = employeeId;
            Fullname = fullname;
            Email = email;
            DepartmentId = departmentId;
            PaymentRegistationNumber = paymentRegistationNumber;
            PaymentAccountNumber = paymentAccountNumber;
            LicensePlate = licensePlate;
        }

        public Employee GetEmployee(int id)
        {
            if (Employees[id] is null)
            {
                // Call the database for the employee
                throw new NotImplementedException();
            }
            return Employees[id];
        }
    }
}
