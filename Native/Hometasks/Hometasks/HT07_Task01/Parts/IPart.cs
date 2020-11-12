using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT07_Task01
{
    enum Status
    {
        READY,
        INPROCESS
    }

    interface IPart
    {
        string Material { get; set; }

        Status Status { get; set; }
    }
}
