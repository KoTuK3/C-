using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex(2, 3);
            Complex num2 = new Complex(0, 0);

            Console.WriteLine("Add: {0}", num1 + num2);
            Console.WriteLine("Sub: {0}", num1 - num2);
            Console.WriteLine("Mul: {0}", num1 * num2);
            Console.WriteLine("Div: {0}", num1 / num2);
        }
    }
}
