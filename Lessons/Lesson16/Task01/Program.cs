using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public sealed class Circle
    {
        private double radius = 5;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.WriteLine($"Length: {circle.Calculate(radius => 2 * Math.PI * radius)}");
        }
    }
}
