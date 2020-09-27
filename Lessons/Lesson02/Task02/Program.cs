using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    partial class Employee
    {        
        public static List<Employee> log { get; set; } = new List<Employee>();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int ContractNumber { get; set; }

        public Employee(string name, string surname, string position, decimal salary, int contractNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.Position = position;
            this.Salary = salary;
            this.ContractNumber = contractNumber;
            AddEmployee(this);
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} ({Position}): {Salary}$, {ContractNumber}");
        }

        public static void AddEmployee(Employee emp)
        {
            log.Add(emp);
        }

        public static void PrintLog()
        {
            foreach (var item in log)
            {
                item.Print();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Employee("Name1", "Surname1", "Pos1", 5000, 0);
            new Employee("Name2", "Surname2", "Pos2", 600, 1);
            new Employee("Name3", "Surname3", "Pos3", 7000, 2);

            Employee.PrintLog();
        }
    }
}
