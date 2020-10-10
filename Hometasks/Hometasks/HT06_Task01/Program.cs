using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT06_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Add(new HelloWorld());
            menu.Add(new Help());
            menu.Add(new Exit());
            menu.Start();
        }
    }
}
