﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT03_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            string row = Console.ReadLine();

            Console.Write("Enter symb: ");
            char ch = (char)Console.Read();

            row = row.Substring(0, row.LastIndexOf(ch) + 1);

            var arr = row.ToCharArray().Select(c => { 
                if (c == ch)
                    return char.ToUpper(c);
                else
                    return c;
            }).ToArray();

            string newRow = new string(arr);
            Console.WriteLine(newRow);
        }
    }
}
