using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT03_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Mary and Samantha arrived at the bus station early but waited until noon for the bus.";
            Console.WriteLine($"Str: {str}");
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                Console.WriteLine($"{ch}: {str.Count(c => char.ToLower(c) == ch)}");
            }
        }
    }
}
