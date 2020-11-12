using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT01_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter str: ");
            string str = Console.ReadLine();

            Console.WriteLine("Num of words: {0}", str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length );
        }
    }
}
