using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_02___Generics
{
    public partial class Form1 : Form
    {
        //int count = 1;
        //StudentLinkedList list = new StudentLinkedList();

        ReadOnly<Student> students = new ReadOnly<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Student student = new Student()
            //{
            //    Name = "Student" + (count++).ToString()
            //};
            //list.Add(student);

            students.Add(new Student());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Qst 01

            Try<int> Qst01 = new Try<int>();

            int[] arr = new int[4];
            int[] arr2 = new int[4];

            Qst01.Add(arr, arr2);

            #endregion

        }

    }
}
