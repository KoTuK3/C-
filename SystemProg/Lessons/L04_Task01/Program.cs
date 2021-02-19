using System;
using System.Threading;

namespace L04_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mutexObj = new Mutex(false, "Test");

            var thread1 = new Thread(() => LockCounter.Count1(mutexObj));
            var thread2 = new Thread(() => LockCounter.Count2(mutexObj));

            thread1.Start();
            thread2.Start();
        }
    }

    public static class LockCounter
    {
        public static void Count1(object obj)
        {
            Mutex m = obj as Mutex;

            m.WaitOne();
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Count: " + i);
            }
            m.ReleaseMutex();
        }

        public static void Count2(object obj)
        {
            Mutex m = obj as Mutex;

            for (int i = 10; i >= 0; i--)
            {
                m.WaitOne();
                Console.WriteLine("Count: " + i);
                m.ReleaseMutex();
            }
        }
    }
}
