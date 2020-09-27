using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int height = rand.Next(5, 10);
            int[][] arr = new int[height][];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[rand.Next(5, 10)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(0, 100);
                }
            }

            Console.WriteLine("Array: ");
            PrintArray(arr);
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr[i]);
            }


            Console.WriteLine("Sorted array: ");
            PrintArray(arr);
        }

        static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0} ", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
