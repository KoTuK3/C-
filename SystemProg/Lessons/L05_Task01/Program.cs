using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L05_Task01
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            var ev = new ManualResetEvent(false);
            var arr = new int[1000];
            var threads = new Thread[4];

            threads[0] = new Thread((obj) =>
              {
                  var tuple = obj as Tuple<int[], EventWaitHandle>;
                  var localArr = tuple.Item1;
                  var handler = tuple.Item2;
                  for (int i = 0; i < localArr.Length; i++)
                  {
                      localArr[i] = rand.Next(5000);
                  }

                  handler.Set();
              });

            threads[1] = new Thread((obj) =>
            {
                var tuple = obj as Tuple<int[], EventWaitHandle>;
                var localArr = tuple.Item1;
                var handler = tuple.Item2;
                handler.WaitOne();

                Console.WriteLine($"Max: {localArr.Max()}");
            });

            threads[2] = new Thread((obj) =>
            {
                var tuple = obj as Tuple<int[], EventWaitHandle>;
                var localArr = tuple.Item1;
                var handler = tuple.Item2;
                handler.WaitOne();

                Console.WriteLine($"Min: {localArr.Min()}");
            });

            threads[3] = new Thread((obj) =>
            {
                var tuple = obj as Tuple<int[], EventWaitHandle>;
                var localArr = tuple.Item1;
                var handler = tuple.Item2;
                handler.WaitOne();

                Console.WriteLine($"Avg: {localArr.Average()}");
            });


            foreach (var thread in threads)
            {
                thread.Start(new Tuple<int[], EventWaitHandle>(arr, ev));
            }
        }
    }
}
