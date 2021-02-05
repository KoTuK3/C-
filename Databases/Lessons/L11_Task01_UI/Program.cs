using L11_Task01_DAL.EF;
using L11_Task01_DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task01_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var bs = new BookService();
            bs.GetBestAuthors(10, new DateTime(2010, 1, 1), new DateTime(2020, 1, 1));




        }
    }
}
