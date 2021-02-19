using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Task02
{
    public static class Analyzer
    {
        public static int Words { get; set; }
        public static int Lines { get; set; }
        public static int Punctuation { get; set; }


        public static void StartAnalyze(string path)
        {
            if (Directory.Exists(path))
            {
                var file = File.ReadAllText(path);
                lock (typeof(Analyzer)) {
                    Lines = file.Count(c => c == '\n');
                    Words = file.Split(
                        new char[] { '.', '?', '!', ' ', ';', ':', ',' },
                        StringSplitOptions.RemoveEmptyEntries)
                    .Length;
                    var punctuation = new char[] 
                    {
                        '.', ',', ';', ':', '–', '—', '‒', '…', '!', '?', '"', '\'', '«', '»', '(', ')', '{', '}', '[', ']', '<', '>', '/'
                    };
                    Punctuation = file.Count(c => punctuation.Contains(c));
                }                
            }
        }
    }
}
