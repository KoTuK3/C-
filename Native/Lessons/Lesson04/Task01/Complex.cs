using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Complex
    {
        public double a { get; set; }
        public double b { get; set; }

        public Complex(double a , double b)
        {
            this.a = a;
            this.b = b;
        }

        public static Complex operator +(Complex left, Complex right)
        {
            Complex res = new Complex(left.a, left.b);
            res.a += right.a;
            res.b += right.b;
            return res;
        }

        public static Complex operator -(Complex left, Complex right)
        {
            Complex res = new Complex(left.a, left.b);
            res.a -= right.a;
            res.b -= right.b;
            return res;
        }

        public static Complex operator *(Complex left, Complex right)
        {
            Complex res = new Complex(left.a, left.b);
            res.a = res.a * right.a - res.b * right.b;
            res.b = res.a * right.b + res.b * right.a;
            return res;
        }

        public static Complex operator /(Complex left, Complex right)
        {
            Complex res = new Complex(left.a, left.b);
            res.a = (res.a * right.a + res.b * right.b) / (Math.Pow(right.a, 2) * Math.Pow(right.b, 2));
            res.b = (res.b * right.a - res.a * right.b) / (Math.Pow(right.a, 2) * Math.Pow(right.b, 2));
            return res;
        }        
        public void Print() 
        {
            Console.WriteLine($"{a} + {b}i");
        }

        public override string ToString()
        {
            return $"{a} + {b}i";
        }
    }
}
