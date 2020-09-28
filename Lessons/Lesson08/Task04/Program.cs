using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    enum Operation
    {
        SUM,
        DIF,
        MUL,
        DIV
    }
    class Calculator
    {
        public Func<double, double, double> Operations;
        public Calculator()
        {
            Operations += (a, b) => a + b;
            Operations += (a, b) => a - b;
            Operations += (a, b) => a * b;
            Operations += (a, b) =>
            {
                if (b != 0)
                    return a / b;
                return 0;
            };
        }
        
        public double Calc(double a, double b, Operation op)
        {
            return (double)Operations.GetInvocationList()[(int)op].DynamicInvoke(a, b);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Sum:" + calc.Calc(5, 5.5, Operation.SUM));
            Console.WriteLine("Dif: " + calc.Calc(5, 5.5, Operation.DIF));
            Console.WriteLine("Mul:" + calc.Calc(15, 3, Operation.SUM));
            Console.WriteLine("Div: " + calc.Calc(15, 3, Operation.DIV));
            Console.WriteLine("Div: " + calc.Calc(15, 0, Operation.DIV));
        }
    }
}
