using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Heater
    {
        public static void Heat(Hothouse h)
        {
            Console.WriteLine($"Temperature is too cold: {h.Temperature}C");
            h.Temperature += 5;
        }
    }
    class Cooler
    {
        public static void Cool(Hothouse h)
        {
            Console.WriteLine($"Temperature is too hot: {h.Temperature}C");
            h.Temperature -= 5;
        }
    }
    class Hothouse
    {
        public delegate void Events(Hothouse prod);
        public event Events TooHot;
        public event Events TooCold;
        public event Events Well;

        public float MaxTemperature { get; private set; } = 50;
        public float MinTemperature { get; private set; } = 20;

        private double temperature;
        public double Temperature
        {
            get
            {
                return temperature;
            } 
            set
            {

                TooHot = TooCold = Well = null;
                temperature = value;
                if (temperature > MinTemperature && temperature < MaxTemperature)
                {
                    Well += hothouse => Console.WriteLine($"Temperature is well: {hothouse.temperature}C");
                    Well?.Invoke(this);
                }
                else if (temperature < MinTemperature)
                {
                    TooCold += hothouse => Heater.Heat(hothouse);
                    TooCold.Invoke(this);
                }
                else if (temperature > MaxTemperature)
                {
                    TooHot += hothouse => Cooler.Cool(hothouse);
                    TooHot?.Invoke(this);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var hothouse = new Hothouse();
            hothouse.Temperature = 56;
            do
            {
                hothouse.Temperature += rand.NextDouble() * 4.0 - 2.0;
                Console.WriteLine($"Current temperature: {hothouse.Temperature}C\n");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
