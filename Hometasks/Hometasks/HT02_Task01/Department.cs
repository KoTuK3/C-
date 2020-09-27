using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT02_Task01
{
    class Department
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public List<Employee> list = new List<Employee>();

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Number: {Number}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void AddEmployee(Employee employee)
        {
            list.Add(employee);
        }
        public void DeleteEmployeeByName(string name, string surname)
        {
            list.Remove(list.Find(x => x.Name == name && x.Surname == surname));
        }

        public void UpdateEmployeeByName(string name, string surname, string newName, string newSurname, decimal newSalary)
        {
            var employe = list.Find(x => x.Name == name && x.Surname == surname);
            employe.Name = newName;
            employe.Surname = newSurname;
            employe.Salary = newSalary;
        }
    }
}
