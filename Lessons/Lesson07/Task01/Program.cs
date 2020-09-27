using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Test_Access;


namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> figures = new List<Rectangle> {
                new Square(1),
                new Paralelepiped(1, 2),
                new Paralelepiped(3, 5),
                new Paralelepiped(9, 6),
                new Square(6),
                new Square(16),
                new Paralelepiped(5, 3),
                new Square(5)
            };
            foreach (var item in figures)
            {
                item.Print();
            }

            Console.Write("All figures have an area greater than 10?: ");

            if (figures.All(x => x.GetArea() > 10))
            {
                Console.WriteLine("Yes.");
            } 
            else
            {
                Console.WriteLine("No.");
            }

            Console.Write("At least one parallelepiped with an area greater than 100?: ");

            if (figures.Any(x => x is Paralelepiped && x.GetArea() > 100))
            {
                Console.WriteLine("Yes.");
            } 
            else
            {
                Console.WriteLine("No.");
            }


            Console.WriteLine("\nThe first square with an area less than 20");
            figures.FirstOrDefault(x => x is Square && x.GetArea() < 20).Print();

            Console.WriteLine("\nThe last square with an area ​​less than 20");
            figures.LastOrDefault(x => x is Square && x.GetArea() < 20).Print();
        }
    }
}
