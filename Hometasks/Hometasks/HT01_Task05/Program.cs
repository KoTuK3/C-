using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT01_Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[,] arr = new int[5, 5];

            Console.WriteLine("Arr: ");
            int min, max, minI, minJ, maxI, maxJ;
            min = max = arr[0, 0];
            minI = minJ = maxI = maxJ = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);

                    if (min > arr[i,j])
                    {
                        min = arr[i, j];
                        minI = i;
                        minJ = j;
                    }

                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                    Console.Write($"{arr[i, j], 5} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Min: {min}, Max {max}");
            int sum = 0;
            if (minI <= maxI || minJ <= maxJ)
            {
                for (int i = minI; i < maxI; i++)
                {
                    for (int j = maxJ; j < maxJ; j++)
                    {
                        sum += arr[i, j];
                    }
                }
            } 
            else
            {
                for (int i = maxI; i < minI; i++)
                {
                    for (int j = maxJ; j < minJ; j++)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
