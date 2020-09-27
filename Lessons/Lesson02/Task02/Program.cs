using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int height = rand.Next(5, 10);
            int width = rand.Next(5, 10);
            int[,] arr = new int[height, width];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-20, 20);
                }
            }

            PrintMatrix(arr);

            Console.WriteLine();
            int min, max, pairedNumbers = 0;
            min = max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                    if (arr[i, j] < min)
                        min = arr[i, j];
                    if (arr[i, j] % 2 == 0)
                        pairedNumbers += 1;
                }
            }

            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Paired numbers: {pairedNumbers}");

        }
        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0, -5} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
