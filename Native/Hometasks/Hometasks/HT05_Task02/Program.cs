using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT05_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department();
            Employeе e1 = new Employeе();
            e1.EnterEmployee();
            Console.WriteLine(e1);

            try
            {
                d.RemoveEmployee(0);
                d.AddToDepartament(e1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
