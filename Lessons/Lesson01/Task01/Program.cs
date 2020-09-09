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
            //    Console.InputEncoding = Encoding.UTF8;
            //char a = Convert.ToChar('a' + 32);
            //Console.WriteLine(a);

            //Task04(5, 1);
            //Task05(543);
            Task06(7, 11);
        }


        static void Task01()
        {
            int counter = 0;
            int key;
            do
            {
                key = Console.Read();
                if (key == ' ')
                    counter += 1;
            } while (key != '.');
            Console.WriteLine($"Sybmols: {counter}");
        }

        static void Task02()
        {
            string str;
            do
            {
                str = Console.ReadLine();
            } while (str.Length != 6);

            char[] numbers = str.ToCharArray();
            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                
                int num = int.Parse(numbers[i].ToString());
                if (i < numbers.Length / 2)
                    sum1 += num;
                else
                    sum2 += num;
            }
            if (sum1 == sum2)
                Console.WriteLine("Lucky ticket");
            else
                Console.WriteLine("Default ticker");

        }
        static void Task03()
        {
            string str = Console.ReadLine();
            string newStr = "";
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                    newStr += (char)(arr[i] + 32);
            }
            
            Console.WriteLine(newStr);
        }

        static void Task04(int a, int b)
        {
            int left = 0, right = 0;
            if (a > b)
            {
                left = b;
                right = a;
            } 
            else
            {
                left = a;
                right = b;
            }
            for (int i = left; i < right; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        static void Task05(int number)
        {
            char[] arr = number.ToString().ToCharArray();
            Array.Reverse(arr);
            
            Console.WriteLine(new string(arr));
        }
        static void Task06(int width, int height)
        {
            int localWidth, localHeight;
            if (width <= 0 || height <= 0)
            { 
                Console.WriteLine("Bad parameters");
                return;
            }

            if (width < height)
            {
                localHeight = width;
                localWidth = height;
            }
            else
            {
                localHeight = height;
                localWidth = width;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < localHeight; i++)
            {
                for (int j = 0; j < localWidth; j++)
                {
                    if (j == localWidth / 2 || i == localHeight / 2)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("# ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
