using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork.Models
{
    class Company
    {
        private string _name;

        public string Name 
        {
            get => _name;
            set
            {
                while (true)
                {
                    bool checkSimvol = true;

                    if (char.IsUpper(value[0]))
                    {
                        foreach (char item in value)
                        {
                            if (!char.IsLetter(item) && !char.IsDigit(item) && !char.IsWhiteSpace(item))
                            {
                                Console.WriteLine("Herf Reqem Ve Bosluqdan Hec Bir Simvol Ola Bilmez");
                                Console.WriteLine("Yeniden Daxil Et");
                                value = Console.ReadLine();
                                checkSimvol = false;
                                break;
                            }
                        }

                        if (checkSimvol)
                        {
                            _name = value;
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ilk Herif Boyuk Olmalidir #");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        public int Limit;
        private Employee[] _employees;

        public Company()
        {
            _employees = new Employee[0];
        }

        public void AddEmoployee(Employee employee)
        {
            if (Limit > _employees.Length)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
                return;
            }
            Console.WriteLine("Elaqe Saxliyaciq In Sha Allah");
        }

        public Employee[] GetEmployees() => _employees;

        public Employee[] SearchEmployees(string search)
        {
            Employee[] newEmployees = new Employee[0];

            foreach (Employee item in _employees)
            {
                if (item.FullName.ToLower().Contains(search.ToLower()) || item.Position.ToLower().Contains(search.ToLower()))
                {
                    Array.Resize(ref newEmployees, newEmployees.Length + 1);
                    newEmployees[newEmployees.Length - 1] = item;
                }
            }

            return newEmployees;
        }

        public void RemoveEmployee(int no)
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                Employee item = _employees[i];

                if (item.No == no)
                {
                    _employees[i] = _employees[_employees.Length - 1];
                    Array.Resize(ref _employees, _employees.Length - 1);
                }
            }
        }
    }
}
