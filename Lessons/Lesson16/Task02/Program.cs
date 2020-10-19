using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(Current));
            Current current;
            using (FileStream fs = new FileStream("weather.xml", FileMode.Open))
            {
                current = (Current)xmlFormatter.Deserialize(fs);
            }


            Console.WriteLine($"Temperature: {current.temperature.value}, Min: {current.temperature.min}, Max: {current.temperature.max}, Units: {current.temperature.unit}");
            
            Console.WriteLine($"Feels_like: {current.feels_like.value}, Units: {current.feels_like.unit}");

            Console.WriteLine($"Humidity: {current.humidity.value}{current.humidity.unit}");

            Console.WriteLine($"Pressure: {current.pressure.value} {current.pressure.unit}");

            Console.WriteLine("Wind");
            Console.WriteLine($"  Speed[{current.wind.speed.name}]: {current.wind.speed.value} {current.wind.speed.unit}");
            Console.WriteLine($"  Direction[{current.wind.direction.name}]: {current.wind.direction.value} {current.wind.direction.code}");

            Console.WriteLine($"Clouds[{current.clouds.name}]: {current.clouds.value}");

            Console.WriteLine($"Visibility: {current.visibility.value}");

            Console.WriteLine($"Precipitation mode: {current.precipitation.mode}");
        }
    }
}
