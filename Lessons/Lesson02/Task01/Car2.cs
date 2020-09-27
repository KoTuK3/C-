using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    partial class Car
    {
        public void Print()
        {
            Console.WriteLine($"Id: {GetUniqueId()}, Model: {GetModel()}, Class: {GetClass()}, Engine: {GetEngine()}, Price: {GetPrice()}");
        }
    }
}
