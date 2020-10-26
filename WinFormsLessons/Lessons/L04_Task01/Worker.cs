using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Task01
{
    class Worker
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public override string ToString()
        {
            return $"{Name} {Position} {Salary} {City} {Street}";
        }
    }
}
