using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegates Home Work Qst 01
            MyFirstDelegate myDelegate1 = new MyFirstDelegate(Print1);
            myDelegate1();

            Console.WriteLine("");

            MyFirstDelegate myDelegate2 = new MyFirstDelegate(Print2);
            myDelegate2();
            #endregion

            Console.WriteLine("");

            #region Delegates Home Work Qst 02
            GreedDelegate greedDelegate1 = new GreedDelegate(PrintParam);
            greedDelegate1("gal");

            Console.WriteLine("");

            GreedDelegate greedDelegate2 = new GreedDelegate(PrintParam2);
            greedDelegate2("elad");
            #endregion

            #region Delegates Home Work Qst 03
            //This One Dosent Work Because the [GreedDelegate] Requires a [String Paramater] and the [Function] that we give him ["Print2"] dosen't [Requires] [Paramater].
            //GreedDelegate greedDelegate1 = new GreedDelegate(Print2);
            #endregion

            #region Delegates Home Work Qst 04
            //Answer is in the Windows Form!!!
            #endregion

            #region Delegates Home Work Qst 05
            StudentsList listStudents = new StudentsList();
            //Here I'm calling the [Function] [Add()] thats [inside] the [listStudents] and his a type of [StudentsList].
            //The [Function] [Add()] needs a [Paramater] of type [Student] which is a [class]. Continue Down VV.
            //And Then hes [Adding] that [Student] that we [Pass] him for Example [listStudents.Add(new Student() { FirstName = "gal" })]. Into are [List<Student>].
            listStudents.Add(new Student() { FirstName = "gal" });
            listStudents.Add(new Student() { FirstName = "elad" });
            listStudents.Add(new Student() { FirstName = "daniel" });

            //Here I'm doing that my [new List<Student>] which is called [stus] will be [Equal /(=)] to the [Function] [Filter]. Continue Down VV.
            //That's [inside] the [class StudentsList] and the [Function] [Filter] he [resturns a List<>] not [void]. Continue Down VV.
            //---[Not Well Explaind]---> And the [Filter] [Function] need a [Paramater] of type [filterDelegate] And that [delegate] need a [Paramater] of type [Student]. Continue Down VV.
            //---[Not Well Explaind]---> So we [Pass] into the [Filter] [Function] the [FilterByFirstName] [Function] Because the [delegate] and the [Function] has to have the [same signature].
            List<Student> stus = listStudents.Filter(FilterByFirstName);
            #endregion

            #region Delegates Home Work Qst 06
            var containsStus = new StudentsList();
            containsStus.Add(new Student() { FirstName = "moshe" , Age = 15});
            containsStus.Add(new Student() { FirstName = " Jonathan" , Age = 21});
            containsStus.Add(new Student() { FirstName = "Amit"  , Age = 30});

            var students = containsStus.Contains(ContainStudents);
            #endregion
        }

        #region Delegates Home Work Qst 01
        static void Print1()
        {
            Console.WriteLine("Hello");
        }

        static void Print2()
        {
            Console.WriteLine("Another Function Called with the same delegate");
        }
        #endregion

        #region Delegates Home Work Qst 02
        static void PrintParam(string name)
        {
            Console.WriteLine(name);
        }

        static void PrintParam2(string name)
        {
            Console.WriteLine("Welcome {0}", name);
        }
        #endregion

        #region Delegates Home Work Qst 03
        //Is In The Main
        #endregion

        #region Delegates Home Work Qst 04
        //Is in the Windows Form Project
        #endregion

        #region Delegates Home Work Qst 05
        static bool FilterByFirstName(Student student)
        {
            //כאן אני מחזיר [בול משתנה]  שעונים על קריטריון מסויים   
            //Here I return a [bool] of students who meet a certain criterion
            if (student.FirstName.Length > 4)
            {
                return true;
            }

            return false;        
        }
        #endregion

        #region Delegates Home Work Qst 06
        static bool ContainStudents(Student student)
        {
            //כאן אני מחזיר [בול משתנה]  שעונים על קריטריון מסויים   
            //Here I return a [bool] of students who meet a certain criterion
            if (student.Age > 20)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
