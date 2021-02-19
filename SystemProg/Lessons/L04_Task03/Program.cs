using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L04_Task03
{
    class Program
    {
        static int[] GenerateArr(int size)
        {
            var rand = new Random();
            var arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(1, 20);
            }
            return arr;
        }

        static void ChangeArr(int[] arr)
        {
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += rand.Next(1, 20);
            }
        }

        static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine();
        }

        static int Max(int[] arr)
        {
            return arr.Max();
        }

        static void Main(string[] args)
        {
            var arr = GenerateArr(10);
            int max = 0;
            Mutex m = new Mutex(false, "Test");
            PrintArr(arr);

            var thread1 = new Thread(() =>
            {
                m.WaitOne();
                ChangeArr(arr);
                m.ReleaseMutex();
            });

            var thread2 = new Thread(() =>
            {
                m.WaitOne();
                max = Max(arr);
                m.ReleaseMutex();
            });

            thread1.Start();
            thread2.Start();

            m.WaitOne();
            PrintArr(arr);
            Console.WriteLine(max);

        }
    }
}
