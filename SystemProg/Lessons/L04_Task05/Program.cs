using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L04_Task05
{
    class Program
    {
        static Random rand = new Random();
        static void PrintRand(object obj)
        {
            var s = obj as Semaphore;
            s.WaitOne();
            Console.Write($"Thread {Thread.CurrentThread.ManagedThreadId}: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{rand.Next(1, 10), 4}");
            }
            Console.WriteLine();
            s.Release();
        }

        static void Main(string[] args)
        {
            Semaphore s = new Semaphore(3, 3);

            for (int i = 0; i < 10; ++i)
                ThreadPool.QueueUserWorkItem(PrintRand, s);

            Console.ReadKey();
            //var threads = new Thread[10];
            //for (int i = 0; i < threads.Length; i++)
            //{
            //    threads[i] = new Thread(() =>
            //    {
            //        PrintRand();
            //        s.Release();
            //    });
            //}

            //foreach (var item in threads)
            //{
            //    item.Start();
            //}
        }
    }
}
