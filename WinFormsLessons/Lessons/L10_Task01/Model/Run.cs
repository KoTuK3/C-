using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_Task01.Model
{
    class Run
    {
        public string Name { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public override string ToString()
        {
            return $"{Name} {ArrivalTime} {DepartureTime}";
        }
    }
}
