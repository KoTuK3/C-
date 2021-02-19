using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task04
{
    class Program
    {
        static void ShowPrime()
        {
            for (int i = 3; i <= 1000; i += 2)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                        
                }
                if (isPrime)
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Task.Run(() => ShowPrime());
            Console.ReadKey();
        }
    }
}
