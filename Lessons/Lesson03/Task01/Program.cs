using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation le = new LinearEquation(0, 6);
            le.Parse("2");
            le.Print();
        }
    }
}
