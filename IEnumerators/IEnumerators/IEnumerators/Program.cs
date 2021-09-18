using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enumerator Qst 01
            Console.WriteLine("Enumerator Qst 01 ");
            //Answer is in the [CountTo100] Class.
            #endregion


            #region Enumerator Qst 02
            Console.WriteLine(" ");
            Console.WriteLine("Enumerator Qst 02 ");

            CountTo100 count = new CountTo100();
            count.CountWithForEach();

            #endregion


            #region Enumerator Qst 03

            Console.WriteLine(" ");
            Console.WriteLine("Enumerator Qst 03 ");

            EnumeratorQst03 qst03 = new EnumeratorQst03(10);
            qst03.CountForEach();

            #endregion


            #region Enumerator Qst 04

            Console.WriteLine(" ");
            Console.WriteLine("Enumerator Qst 04");
            Console.WriteLine(" ");


            List<Student> studentss = new List<Student>()
            {
                new Student(90,"Gal"),
                new Student(80,"Daniel"),
                new Student(70,"Kantor"),
                new Student(5,"Jonathan")

            };

            foreach (Student stu in new StudentsWhoParcticeAlot(studentss))
            {
                if(stu.Grade >= 10)
                {
                  Console.WriteLine($"Student Name = {stu.Name}.  Student Grade = {stu.Grade}.");
                }
            }
            
            #endregion

        }
    }

    class CountTo100 : IEnumerable
    {
        #region Enumerator Qst 01

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i * 10;
            }
        }

        #endregion


        #region Enumerator Qst 02

        public void CountWithForEach()
        {
            foreach (var item in new CountTo100())
            {
                Console.WriteLine(item);
            }
        }

        #endregion



        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }



    class EnumeratorQst03 : IEnumerable<int>
    {
        public int Num { get; set; }


        public EnumeratorQst03(int num)
        {
            Num = num;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i * 10;
            }
        }

        #region Enumerator Qst 03

        public void CountForEach()
        {
            foreach (var item in new CountTo100())
            {
                Console.WriteLine(item);
            }
        }

        #endregion


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
