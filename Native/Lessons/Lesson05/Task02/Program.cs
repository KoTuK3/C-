using System;
using System.Collections.Generic;

namespace Task02
{
    class Shape
    {
        public virtual string Name { get => "Shape"; }
        public virtual double Square { get => 0; }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Square: {Square}");
        }

    }
    class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override string Name => this.GetType().Name;
        public double Radius { get; set; }
        public override double Square => Math.PI * Math.Pow(Radius, 2);
        public override void Print()
        {
            base.Print();
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override string Name => this.GetType().Name;
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Square => Height * Width;
        public override void Print()
        {
            base.Print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<Shape>() {
                new Circle(5),
                new Circle(6),
                new Rectangle(2, 2),
                new Rectangle(3, 4),
            };

            foreach (var item in arr)
            {
                item.Print();
            }

            Console.WriteLine("\nSorted array");
            arr.Sort((shape1, shape2) => shape1.Square.CompareTo(shape2.Square));
            foreach (var item in arr)
            {
                item.Print();
            }

            Console.WriteLine("\nCircles");
            var circles = arr.FindAll(shape => shape.Name.Equals("Circle"));
            foreach (var item in circles)
            {
                item.Print();
            }
        }
    }
}
