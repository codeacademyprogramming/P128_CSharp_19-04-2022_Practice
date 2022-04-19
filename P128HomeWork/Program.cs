using P128HomeWork.Models;
using System;

namespace P128HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Hamid Mammadov", 15000000, "Programming Instructor");
            Employee employee2 = new Employee("Qurban Zakiri", 15000000, "Sales Manager");
            Employee employee3 = new Employee("Metin Nejefov", 15000000, "Front office Manager");
            Employee employee4 = new Employee("Nicat Muxtarov", 15000000, "GPS");
            Employee employee5 = new Employee("Leman Memmedli", 15000000, "Call Center");
            Employee employee6 = new Employee("Murad Abdullayev", 15000000, "IT Manager");
            Employee employee7 = new Employee("Ziver Babayeva", 15000000, "Account");

            Company company = new Company();
            company.Name = "Code Academy";
            company.Limit = 7;
            company.AddEmoployee(employee1);
            company.AddEmoployee(employee2);
            company.AddEmoployee(employee3);
            company.AddEmoployee(employee4);
            company.AddEmoployee(employee5);
            company.AddEmoployee(employee7);
            company.AddEmoployee(employee6);

            Employee[] employees = company.GetEmployees();

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine($"{employee.No} {employee.FullName} {employee.Salary} {employee.Position}");
                }
            }

            while (true)
            {
                Console.WriteLine("Silmek Isdediyin Iscinin Nomresini Daxil Et");
                string employeeNo = Console.ReadLine();
                int.TryParse(employeeNo, out int no);
                company.RemoveEmployee(no);

                foreach (Employee employee in company.GetEmployees())
                {
                    Console.WriteLine($"{employee.No} {employee.FullName} {employee.Salary} {employee.Position}");
                }

                Console.WriteLine("Yene Silmek Isdeyirsiz y/n");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    break;
                }
            }

            //Console.WriteLine("\n-----Search-----\n");
            //Console.WriteLine("Daxil Et:");
            //string search = Console.ReadLine();

            //Employee[] searchedEmployees = company.SearchEmployees(search);

            //foreach (Employee item in searchedEmployees)
            //{
            //    Console.WriteLine($"{item.No} {item.FullName} {item.Salary} {item.Position}");
            //}
        }
    }
}
