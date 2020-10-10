using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT06_Task01
{
    class HelloWorld : MenuItem
    {
        public HelloWorld()
        {
            Text = "Hello world";
        }

        public override void Execute()
        {
            Console.WriteLine("Hello world.");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
