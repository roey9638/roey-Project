using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Threads
    {
        public void Thread1()
        {
            Thread threads1 = new Thread(() =>
            {
                int sum = 0;
                for (int i = 0; i < 100; i++)
                {
                    sum += i;
                }
                Debug.WriteLine(sum);
            });
            threads1.Start();
        }

        public void Thread2()
        {
            Thread threads2 = new Thread(() =>
            {
                int sum = 0;
                for (int i = 0; i < 200; i++)
                {
                    sum += i;
                }
                Debug.WriteLine(sum);
            });
            threads2.Start();
        }
    }
}
