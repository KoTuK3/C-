using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT06_Task01
{
    abstract class MenuItem
    {
        public string Text { get; set; }
        virtual public void Execute()
        {
            return;
        }
    }
}
