using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L05_Task02
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            var ev = new ManualResetEvent(false);
            var arr = new int[10];
            var threads = new Thread[2];
            var elem = 10;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(20);
            }
            

            threads[0] = new Thread((obj) =>
            {
                var tuple = obj as Tuple<int[], int, EventWaitHandle>;
                var localArr = tuple.Item1;
                var handler = tuple.Item3;

                Array.Sort(localArr);

                handler.Set();
            });

            threads[1] = new Thread((obj) =>
            {
                var tuple = obj as Tuple<int[], int, EventWaitHandle>;
                var localArr = tuple.Item1;
                var element = tuple.Item2;
                var handler = tuple.Item3;

                handler.WaitOne();

                Console.WriteLine($"Elem {element}: {localArr.Contains(element)}");
            });

            foreach (var thread in threads)
            {
                thread.Start(new Tuple<int[], int, EventWaitHandle>(arr, elem, ev));
            }
        }
    }
}
