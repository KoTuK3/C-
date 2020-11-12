using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT11_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> doc = new List<string>();

            using (StreamReader reading = File.OpenText("test.cs"))
            {
                string str;
                while ((str = reading.ReadLine()) != null)
                {
                    if (str.Contains("//"))
                    {
                        int index = str.LastIndexOf("//");
                        doc.Add(str.Substring(0, index));
                    }
                    else
                    {
                        doc.Add(str);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("test.cs"))
            {
                foreach (var item in doc)
                {
                    writer.WriteLine(item);
                }
            }
        }
                
    }
}
