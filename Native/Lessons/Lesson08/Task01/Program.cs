using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    
    class Program
    {
        public static void DrawSquare(int height, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public static void DrawTriangle(int height, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i >= j)
                        Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        public delegate void Draw(int height, ConsoleColor color);

        public static void Print(int numOfFigures, Draw func, int height, ConsoleColor color)
        {
            for (int i = 0; i < numOfFigures; i++)
            {
                func(height, color);
            }
        }
        static void Main(string[] args)
        {
           Draw draw = new Draw(DrawSquare);
           draw += DrawTriangle;


            Print(5, draw, 5, ConsoleColor.Cyan);
        }
    }
}
