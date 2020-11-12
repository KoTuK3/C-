using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT05_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation le = new LinearEquation(0, 6);
            le.Parse("2x + 3");

            try
            {
                le.Parse("2");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            le.Print();
        }
    }
}
