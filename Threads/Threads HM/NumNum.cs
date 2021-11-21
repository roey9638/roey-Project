using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_HM
{
    class NumNum
    {
        public Thread thread;
        public int sleepTime;


        public void Sleep()
        {
            Console.WriteLine($"{thread.Name} going to sleep");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"{thread.Name} done sleeping");
        }

        public NumNum(string threadName)
        {
            thread.Name = threadName;

            sleepTime = new Random().Next(5);

            thread = new Thread(() => Sleep());

            Console.WriteLine($"The Thread Name Is: {thread.Name}, And Sleep time Is: {sleepTime} seconds");
        }
    }

    class NumNum2
    {
        public Task task;
        public int sleepTime;


        public void Sleep()
        {
            Console.WriteLine($"{task.Id} going to sleep");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"{task.Id} done sleeping");
        }

        public NumNum2(string threadName)
        {
            //task.Name = threadName;

            sleepTime = new Random().Next(5);

            task = new Task(() => Sleep());

            Console.WriteLine($"The Thread Name Is: {task.Id}, And Sleep time Is: {sleepTime} seconds");
        }
    }
}
