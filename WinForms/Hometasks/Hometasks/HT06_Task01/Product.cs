using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_Task01
{
    public class Product
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Name} {Price.ToString("#.##")}$";
        }
    }
}
