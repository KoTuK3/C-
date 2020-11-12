using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class User
    {
        public string name;
        public string surname;

        public void NotifyHandler(Product prod)
        {
            Console.WriteLine($"Dear, {name} {surname}, price changed on product {prod.name}");
        }
    }
    class Product
    {
        public string name;
        public delegate void NotifyHandler(Product prod);
        public event NotifyHandler Notify;
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < price)
                    OnChange();
                price = value;
            }
        }

        public void OnChange()
        {
            Notify?.Invoke(this);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User() { name = "name1", surname = "surname1" };
            var user2 = new User() { name = "name2", surname = "surname2" };
            var user3 = new User() { name = "name3", surname = "surname3" };

            var product1 = new Product() { name = "Product1", Price = 100 };
            var product2 = new Product() { name = "Product2", Price = 100 };

            product1.Notify += user1.NotifyHandler;
            product1.Notify += user3.NotifyHandler;

            product2.Notify += user3.NotifyHandler;
            product2.Notify += user2.NotifyHandler;


            product1.Price = 50;
            product2.Price = 50;


        }
    }
}
