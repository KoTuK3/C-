using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    [Serializable]
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double AvrMark { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname}: {AvrMark}");
        }
    }

    class StudentFS
    {
        public static void Write(Student student)
        {
            using (Stream stream = File.Open("student", FileMode.Create))
            {
                var formatter = new BinaryFormatter();

                formatter.Serialize(stream, student);
            }
        }

        public static Student Read()
        {
            using (Stream stream = File.Open("student", FileMode.Open))
            {
                var formatter = new BinaryFormatter();

                return (Student)formatter.Deserialize(stream);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var st1 = new Student()
            {
                Name = "Name1",
                Surname = "Surname1",
                AvrMark = 10.6
            };
            st1.Print();

            var st2 = StudentFS.Read();
            st2.Print();
        }
    }
}
