using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            var dic = new Dictionary<string, int>();
            foreach (var item in str.Split(new[] { " ", ",", ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (dic.ContainsKey(item))
                {
                    dic[item] += 1;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }

            int allWords = 0, i = 1;
            foreach (var item in dic)
            {
                Console.WriteLine($"{i++, 4}. {item.Key, -20} {item.Value, -10}");
                allWords += item.Value;
            }

            Console.WriteLine($"All words: {allWords}, Unique words: {dic.Count()}");
        }
    }
}
