using System;
using System.Threading;

namespace ThreadPriorityApp
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;
            for (int loopCount = 0; loopCount < 3; loopCount++)
            {
                Thread.Sleep(500); // 0.5-second delay
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);
            }
        }

        public static void Thread2()
        {
            Thread thread = Thread.CurrentThread;
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread.Sleep(1500); // 1.5-second delay
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);
            }
        }
    }
}