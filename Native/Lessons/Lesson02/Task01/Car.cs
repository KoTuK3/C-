using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    partial class Car
    {
        public static int CounterId { get; private set; }
        public static double NumberOfWheels { get; set; }
        private string Model;
        private string Engine;
        private string Class;
        private double Price;
        private int UniqueId;
        static Car()
        {
            CounterId = 0;
            NumberOfWheels = 4;
        }
        public Car()
        {
            UniqueId = CounterId;
            CounterId += 1;
        }

        public Car(string Model, string Engine, string Class, double Price)
        {
            SetModel(Model);
            SetEngine(Engine);
            SetClass(Class);
            SetPrice(Price);
            UniqueId = CounterId;
            CounterId += 1;
        }

        public string GetModel()
        {
            return Model;
        }
        public string GetEngine()
        {
            return Engine;
        }
        public string GetClass()
        {
            return Class;
        }
        public double GetPrice()
        {
            return Price;
        }
        public double GetUniqueId()
        {
            return UniqueId;
        }
        public void SetModel(string Model)
        {
            this.Model = Model;
        }
        public void SetEngine(string Engine)
        {
            this.Engine = Engine;
        }
        public void SetClass(string Class)
        {
            this.Class = Class;
        }
        public void SetPrice(double Price)
        {
            this.Price = Price;
        }
    }
}
