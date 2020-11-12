using System;

namespace Test_Access
{
    public class Rectangle
    {
        protected double Height { get; set; }
        protected double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double GetArea()
        {
            return Height * Width;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {this.GetType(), -30} Height: {Height}, Width: {Width}");
        }
    }

    public class Square : Rectangle
    {
        public Square(double a) : base(a, a)
        {

        }

        public override void Print()
        {
            Console.WriteLine($"Name: {this.GetType(),-30} Size: {Height}");
        }
    }

    public class Paralelepiped : Rectangle
    {
        public Paralelepiped(double a, double b) : base(a, b)
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
