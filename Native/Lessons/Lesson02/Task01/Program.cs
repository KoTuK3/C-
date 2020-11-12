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
            List<Car> cars = new List<Car>
            {
                new Car("Model1", "Engine1","Class1", 100),
                new Car("Model2", "Engine2","Class2", 200),
                new Car("Model3", "Engine3","Class3", 300),
                new Car("Model4", "Engine4","Class4", 400),
                new Car("Model5", "Engine5","Class5", 500),
            };

            foreach(var el in cars)
            {
                el.Print();
            }
        }
    }
}
