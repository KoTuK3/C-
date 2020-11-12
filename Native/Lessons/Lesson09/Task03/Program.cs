using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Game
    {
        public delegate void Events(Vehicle vehicle, int number);
        int counterCarOnFinish;
        public event Events OnFinish;
        private int start = 0;
        private int end = 100;

        List<int> vehiclesPositions = new List<int>();
        List<Vehicle> vehicles = new List<Vehicle>();

        public Game()
        {
            counterCarOnFinish = 0;
        }

        public void AddVehicle(Vehicle v)
        {
            vehicles.Add(v);
        }

        public void Print()
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine($"Car[{i+1}], Pos: {vehiclesPositions[i]}");
            }
        }

        public void Start()
        {

        }


    }

    class Vehicle
    {
        static Random rand = new Random();
        public int Speed { get; private set; }

        private int MinSpeed;
        private int MaxSpeed;

        public Vehicle(int minSpeed, int maxSpeed)
        {
            MinSpeed = minSpeed;
            MaxSpeed = maxSpeed;
        }

        public int GenerateRandSpeed()
        {
            return rand.Next(MinSpeed, MaxSpeed);
        }

        public int Drive()
        {
            return GenerateRandSpeed();
        }

        public void Print()
        {
            Console.WriteLine($"Type: {this.GetType()}, Speed: {Speed} ");
        }
    }

    class Track : Vehicle
    {
        public Track() : base(0, 100) { }
    }

    class Bus : Vehicle
    {
        public Bus() : base(0, 60) { }
    }

    class Car : Vehicle
    {
        public Car() : base (0, 150) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
