using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class StudentsList
    {
        static List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }

        public List<Student> Filter(filterDelegate filterDelegate)
        {
            var studentList = new List<Student>();
            foreach (var student in students)
            {
                if (filterDelegate(student))
                {
                    studentList.Add(student);
                }
            }
            return studentList;
        }


        #region Qst 06
        public bool Contains(ContainDelegate containDelegate)
        {
            foreach (Student student in students)
            {
                if (containDelegate(student))
                    return true;
            }
            return false;
        }
        #endregion

    }

    public class Student
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}
