using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerators
{
    class StudentsWhoParcticeAlot : IEnumerable<Student>
    {
        public List<Student> Students { get; set; }


        public StudentsWhoParcticeAlot(List<Student> students)
        {
            Students = students;
        }


        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in Students)
            {
                if (student.Grade >= 10)
                {
                    yield return student;
                }

            }
        }

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }

        public Student(int grade, string name)
        {
            Grade = grade;
            Name = name;
        }

    }
}
