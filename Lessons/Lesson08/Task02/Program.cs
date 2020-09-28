using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Student : ICloneable
    {
        private string name;   // default? null
        private int age;   // 0
        private DateTime? date;   // 01.01.0001 00:00
        public string Group { get; set; } // auto property (автоматична властивість, використовуємо, якщо не треба валідація)
        public float AvgMark { get; private set; }
        public static int Id { get; set; }

        public int MarkProg { get; set; }
        public int MarkAdmin { get; set; }
        public int MarkDesign { get; set; }

        public void PrintMarkProg()
        {
            Console.WriteLine("Mark prog" + MarkProg);
        }
        public void PrintMarkAdmin()
        {
            Console.WriteLine("Mark admin" + MarkAdmin);
        }
        public void PrintMarkDesign()
        {
            Console.WriteLine("Mark design" + MarkDesign);
        }
        public delegate void PrintMark();

        public PrintMark printMark;
        public void Info(string[] subjects)
        {
            if (subjects.Contains("prog"))
                printMark += PrintMarkProg;
            if (subjects.Contains("admin"))
                printMark += PrintMarkAdmin;;
            if (subjects.Contains("design"))
                printMark += PrintMarkDesign;
            if (subjects.Contains("All"))
            {
                printMark += PrintMarkDesign;
                printMark += PrintMarkAdmin;
                printMark += PrintMarkProg;
            }

            printMark();

        }

        #region ctors
        static Student()
        {
            Id = 100;
        }
        public Student()
        {
            Name = "Alex";
            //    Age = 11;
            //   Date = DateTime.Now;
            Id++;
        }

        public Student(string name, int age, DateTime date)
        {
            this.name = name;
            this.age = age;
            this.date = date;
            Id++;
        }

        public Student(string name)
        {
            Id++;
            this.name = name;
        }
        #endregion


        public DateTime? Date
        {
            get { return date; }
            set
            {
                date = value;
                Age = 1;
            }
        }

        public static void ShowId()
        {
            Console.WriteLine("ID: " + Id);
        }

        public int Age
        {
            get { return age; }
            private set { age = DateTime.Now.Year - ((DateTime)date).Year; }
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                    return;
                }
                throw new Exception("Bad name");
            }
        }

        public void Print()
        {
            Console.WriteLine($"{Name} -> {Age} -> date: {Date}");
        }

        public override string ToString()
        {
            return $"name: {Name} ==> age: {Age} ==> group: {Group}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            s.MarkAdmin = 5;
            s.MarkDesign = 3;
            s.MarkProg = 4;
            s.Info(new string[] { "admin", "design" });
        }
    }
}
