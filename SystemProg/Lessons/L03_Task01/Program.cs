using System;
using System.Threading;

namespace L03_Task01
{
    class Fib
    {
        private int f1 = 0;
        private int f2 = 1;
        private int sum = 0;
        private int counter = 0;
        private int evenCount = 0;

        public void CalcFib()
        {
            lock (this)
            {
                sum = f1 + f2;
                f1 = f2;
                f2 = sum;
                counter += 1;

                if (f2 % 2 == 0)
                    evenCount += 1;

                Console.WriteLine($"{counter, 10} {f1, 20} {f2, 20} {evenCount,20}");
            }     
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var threads = new Thread[3];
            var f = new Fib();

            Console.WriteLine($"{"Iteration", 10} {"f1",20} {"f2",20} {"evenCount",20}");
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        f.CalcFib();
                    }
                });
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; ++i)
                threads[i].Join();
        }
    }
}
