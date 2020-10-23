using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Task01
{
    class ToDo
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Priority { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Name} {Place} {Date} {Priority}";
        }
    }
}
