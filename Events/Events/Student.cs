using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Student
    {
        public string Name{ get; set; }
        public int Age { get; set; }
    }
    public class StudentList 
    {
        #region Delegate HM Qst 03
        public static event DelegateStudents delegateStudents;

        List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            students.Add(student);
            if (students.Count % 5 == 0)
            {
                if (delegateStudents != null)
                {
                    delegateStudents();
                }
            }
        }
        public static void Message()
        {
            Console.WriteLine("You get 5% discount");
        }
        #endregion
    }
}
