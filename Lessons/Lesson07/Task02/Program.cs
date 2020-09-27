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
            ConsoleColor color = ConsoleColor.Red;

            var colorsNames = Enum.GetNames(typeof(ConsoleColor));
            Console.WriteLine("Task 1");
            foreach (var item in colorsNames)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTask 2");
            for (int i = 0; i < Enum.GetNames(typeof(ConsoleColor)).Length; i++)
            {
                if (i == 10 || i == 22)
                    Console.WriteLine((ConsoleColor)i);
            }

            Console.WriteLine("\nTask 3");
            string strColor = Console.ReadLine();
            ConsoleColor customColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), strColor);
            Console.BackgroundColor = customColor;
            Console.WriteLine(customColor);

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
