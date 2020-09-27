using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT01_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter str: ");
            string str = Console.ReadLine();
            var charStr = str.ToCharArray();
            Array.Reverse(charStr);
            if (new string(charStr) == str)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }
    }
}
