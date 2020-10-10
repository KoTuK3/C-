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

            string minWord, maxWord;
            minWord = maxWord = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (minWord.Length > words[i].Length)
                    minWord = words[i];
                if (maxWord.Length < words[i].Length)
                    maxWord = words[i];
            }

            Console.WriteLine($"Sentence: {sentence}");
            Console.WriteLine($"Min word: {minWord}");
            Console.WriteLine($"Max word: {maxWord}");
        }
    }
}
