using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_HM
{
    class Threads
    {
        long sum = 0;
        Thread thread1;
        Thread thread2;

        public Threads()
        {

        }



        #region Qst 01
        public void Qst01()
        {
            Thread thread1 = new Thread(() =>
            {
                for (int i = 1; i < 2500; i++)
                {
                    Console.WriteLine(i);
                }
            });
            thread1.Start();
            thread1.Join();

            Thread thread2 = new Thread(() =>
            {
                for (int i = 2501; i <= 5000; i++)
                {
                    Console.WriteLine(i);
                }
            });
            thread2.Start();

            thread2.Join();
        }
        #endregion

        #region Qst 02
        public void Qst02()
        {
            Thread thread3 = new Thread(() =>
            {
                var files1 = Directory.GetFiles(@"C:\Users\roey1\Desktop\שעורי בית גמורים\Net. מתקדם\שיעור 12\Threads\Threads HM");

                foreach (var item in files1)
                {
                    Console.WriteLine(item);
                }

            });
            thread3.Start();
            thread3.Join();

            Console.WriteLine(" ");
            Console.WriteLine("Here is Other Two files from other (Thread)");
            Console.WriteLine(" ");

            Thread thread4 = new Thread(() =>
            {
                var files2 = Directory.GetFiles(@"C:\Users\roey1\Desktop\שעורי בית גמורים\Net. מתקדם\שיעור 12\Threads\Threads");

                foreach (var item in files2)
                {
                    Console.WriteLine(item);
                }

            });
            thread4.Start();
            thread4.Join();
        }
        #endregion

        #region Qst 03
        //Qst 03 is in the [NumNum Class].
        #endregion

        //Not Right!!!
        #region Qst 04
        void AddtoSum(long value)
        {
            object objectt = new object();

            lock (objectt)
            {
                sum += value;
                Console.WriteLine(sum);
            }
        }


        public void Qst04()
        {
            thread1 = new Thread(() => SumNumbers1(10));
            thread1.Start();
            thread1.Join();

            thread2 = new Thread(() => SumNumbers2(10));
            thread2.Start();
            thread2.Join();

        }

        void SumNumbers1(long num)
        {
            for (int i = 0; i < num / 2; i++)
            {
                AddtoSum(i);
            }
        }

        void SumNumbers2(long num)
        {
            int num2 = (int)num / 2 + 1;

            for (int i = num2; i < num; i++)
            {
                AddtoSum(i);
            }
        }
        #endregion

        #region Qst 05
        //Answer in the Seachh Class.
        #endregion
    }
}
