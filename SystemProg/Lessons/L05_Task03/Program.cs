using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L05_Task03
{
    class Program
    {
        static void ShowCurrentDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy - HH:mm:ss.FFFFFFF"));
        }
        static void Main(string[] args)
        {
            var task = new Task(ShowCurrentDate);
            task.Start();
            Task.Factory.StartNew(ShowCurrentDate);
            Task.Run(ShowCurrentDate);

            Console.ReadKey();
        }
    }
}
