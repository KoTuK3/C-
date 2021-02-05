using System;
using System.Data.Entity;
using System.Linq;

namespace L08_Task01
{
    public class Model1 : DbContext
    {       
        public Model1()
            : base("name=Model1")
        {
        }
    }



}