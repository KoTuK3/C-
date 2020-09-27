using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Task01
{
    static class Extension
    {
        public static string Reverse(this string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        public static int CountUpper(this string str)
        {
            return str.ToCharArray().Where(ch => char.IsUpper(ch)).Count();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123".Reverse());
            Console.WriteLine("AAAbbaZZ".CountUpper());
        }
    }
}