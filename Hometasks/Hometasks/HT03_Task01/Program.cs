using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace HT03_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Mary and Samantha arrived at the bus station early but waited until noon for the bus.";
            var words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string max = words.Where(word => { 
                
            });
        }
    }
}
