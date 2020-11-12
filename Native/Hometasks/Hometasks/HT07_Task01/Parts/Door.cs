﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT07_Task01
{
    class Door : IPart
    {
        public string Material { get; set; }
        public Status Status { get; set; }

        public Door(string material = "Metal", Status status = Status.INPROCESS)
        {
            Material = material;
            Status = status;
        }

        public override string ToString()
        {
            return ($"Door, material: {Material}, Status: {Status}");
        }
    }
}
