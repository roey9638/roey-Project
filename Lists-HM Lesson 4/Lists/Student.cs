using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Student : IComparable<Student>
    {
        #region Example class
        //public string Name { get; set; }

        //List<Student> list = new List<Student>();

        //public Student(string name)
        //{
        //    Name = name;
        //}
        #endregion


        public static List<Student> list = new List<Student>();


        public int id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }




        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            id = GetId.StudentId();
        }


        //First Test Sorting The List By [Last Name]
        public int CompareTo(Student other)
        {
            return this.LastName.CompareTo(other.LastName);
        }


        //Change fro the [namespace] to show. that it will show the [propety] of the [student].
        public override string ToString()
        {
            return $"{FirstName} {LastName} {id}";
        }

    }


    //---[Qst01 .A]--- Sorting The List By [Last Name]
    public class SortLastName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }


    //---[Qst01 .B]--- Sorting The List By [Grade]
    public class SortByGrade : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Grade.CompareTo(y.Grade);
        }
    }


    //---[Qst01 .C]--- Sorting The List By [Last Name] then [First Name]
    //---[Qst01 .D]--- Sorting The List By [Last Name] then [First Name] and [Grade].
    public class SortLastAndFirstName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            //So if the [Last Name] of the [first Name in the list] is (Equal / CompareTo) the [Last Name] of the [second Name in the list]
            //then do (Equal / CompareTo) to the [return x.FirstName.CompareTo(y.FirstName)].
            //If this is [False] then it will go to the lasr [return] and do the (Equal / CompareTo) with [x.LastName.CompareTo(y.LastName)].
            if (x.LastName.CompareTo(y.LastName) == 0)
            {
                //Here im checking if [x.FirstName] is and [y.FirstName] are (Equal == 0) if yes then. Continue Down VV.
                if (x.FirstName.CompareTo(y.FirstName) == 0)
                {
                    //Then do (Equal / CompareTo) with [Grade] and then Revesrse it with (-1).
                    return x.Grade.CompareTo(y.Grade) * -1;
                }
                return x.FirstName.CompareTo(y.FirstName);
            }
            //Else then just do (Equal / CompareTo) [Last Name].
            return x.LastName.CompareTo(y.LastName);
        }
    }

   



    class GetId
    {
        static int index = 0;


        static public int StudentId()
        {
            return index++;
        }
    }

}
