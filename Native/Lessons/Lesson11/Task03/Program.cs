using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task03
{
    class FileSystem
    {
        public static void WriteRows(string[] rows, string path = "lines1.txt")
        {
            File.WriteAllLines(path, rows);
        }

        public static string[] ReadRows(string path = "lines1.txt")
        {
            return File.ReadAllLines(path);
        }

        public static void ReadAndPrintRows(string path = "lines1.txt")
        {
            string[] rows = ReadRows(path);
            foreach (var row in rows)
                Console.Write(row);
        }

        public static void Append(string to = "lines1.txt", string from = "lines2.txt")
        {
            using (FileStream fs1 = new FileStream(to, FileMode.Append))
            {

                using (FileStream fs2 = new FileStream(from, FileMode.Open))
                {
                    fs2.Seek(10, SeekOrigin.Begin);
                    fs2.CopyTo(fs1);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileSystem.WriteRows(new[] { "1. Row", "2. Row", "3. Row", "4. Row" });
            FileSystem.WriteRows(new[] { "5. Row", "6. Row", "7. Row", "8. Row" }, "lines2.txt");

            FileSystem.Append();
            FileSystem.ReadAndPrintRows();
            FileSystem.ReadAndPrintRows();

            Console.WriteLine();
        }
    }
}
