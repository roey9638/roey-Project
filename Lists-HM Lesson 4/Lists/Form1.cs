using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Extensions Qst04

            int num = Convert.ToInt32(AddNumber.Text);
            int multiplyNum = Convert.ToInt32(MultiplyNumber.Text);
            int result = num.MultipleBy(multiplyNum);

            #endregion
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PutName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Exetension Qst05

            string name = PutName.Text;
            if (!name.IsNull())
            {
                Debug.WriteLine("hey");
            }

            #endregion
        }
    }
}
