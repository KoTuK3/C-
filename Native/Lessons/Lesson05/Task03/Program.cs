using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Menu
    {
        private List<string> lines = new List<string>();
        private bool isLastExit;
        public int Selector { get; private set; }
        public Menu(List<string> lines, bool isLastExit = true)
        {
            Selector = 0;
            this.lines = lines ?? new List<string>();
            this.isLastExit = isLastExit;
            if (isLastExit)
                lines.Add("Exit");
        }

        public void ShowLines()
        {
            Console.Clear();
            for (int i = 0; i < lines.Count(); i++)
            {
                if (i == Selector)
                    Console.WriteLine($"> {lines[i]}");
                else
                    Console.WriteLine(lines[i]);
            }
            Console.WriteLine();
        }

        public void UpdateMenu()
        {
            do
            {
                var key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        return;

                    case ConsoleKey.W:
                        Selector -= 1;
                        break;
                    case ConsoleKey.S:
                        Selector += 1;                        
                        break;
                }

                if (Selector >= lines.Count())
                    Selector = 0;
                else if (Selector < 0)
                    Selector = lines.Count() - 1;
                ShowLines();
            } while (true);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "a", "b", "c" };
            Menu m = new Menu(list);
            m.ShowLines();
            m.UpdateMenu();
            //var cd = new CD();
            //cd.Write("Cd text");            

            //var comp = new Comp();
            //comp.AddDisc(cd);
            //comp.InsertReject(cd.GetName(), true);
            //Console.WriteLine( "Info: {0}", comp.ReadInfo(cd.GetName()));


            //char key = '0';
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("1. Add disk");
            //    Console.WriteLine("2. Add printer device");
            //    Console.WriteLine("0. Exit");
            //    key = (char)Console.Read();

            //    switch (key)
            //    {
            //        case '1':
            //            Console.Clear();
            //            Console.WriteLine("1. Add hdd");
            //            Console.WriteLine("2. Add cd");
            //            Console.WriteLine("3. Add flash");
            //            Console.WriteLine("4. Add dvd");
            //            key = (char)Console.Read();

            //            break;
            //        case '2':
            //            Console.Clear();
            //            Console.WriteLine("1. Add printer");
            //            Console.WriteLine("2. Add monitor");
            //            break;
            //        default:
            //            break;
            //    }
            //} while (key < '1' || key > '2');


        }
    }
}
