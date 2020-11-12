using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT03_Task03
{
    class Program
    {
        static void EncryptStr(ref string str)
        {
            var arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }

            str = new string(arr);
        }

        static void DecryptStr(ref string str)
        {
            var arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }

            str = new string(arr);
        }

        static void RemoveFirstWord(ref string str)
        {
            if (str.Length > 0)
            {
                int i = str.IndexOf(" ") + 1;
                string newStr = str.Substring(i);
                str = newStr;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter sentece: ");
            //string str = Console.ReadLine();
            //string str = "encrypt Mary and Samantha arrived at the bus station early but waited until noon for the bus.";
            string str = "decrypt Nbsz!boe!Tbnbouib!bssjwfe!bu!uif!cvt!tubujpo!fbsmz!cvu!xbjufe!voujm!oppo!gps!uif!cvt/";

            var arr = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            RemoveFirstWord(ref str);
            switch (arr[0].ToLower())
            {
                case "encrypt":
                    EncryptStr(ref str);
                    break;
                case "decrypt":
                    DecryptStr(ref str);
                    break;
            }
            Console.WriteLine(str);

        }
    }
}
