using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork.Models
{
    class Employee
    {
        private static int Id;

        public readonly int No;
        public string FullName;
        public double Salary;
        public string Position;

        static Employee()
        {
            Id = 1;
        }

        public Employee(string fullName, double salary, string position)
        {
            No = Id;
            Id++;
            FullName = fullName;
            Salary = salary;
            Position = position;
        }
    }
}
