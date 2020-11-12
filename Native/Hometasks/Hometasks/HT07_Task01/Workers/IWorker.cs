using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT07_Task01
{
    interface IWorker
    {
        string Name { get; set; }

        void DoWork(House house);
    }
}
