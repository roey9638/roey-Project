using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delegate;
namespace Delagate_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Delegates Home Work Qst 04
        int Add(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        int Sub(int num1, int num2)
        {
            int result = num1 - num2;

            return result;
        }
        #endregion

        private void Adding_Button_Click(object sender, EventArgs e)
        {
            #region Delegates Home Work Qst 04

            TwoNumDelegate twoNumDelegate = Add;
            int num1 = twoNumDelegate(2, 2);

            #endregion
        }

        private void Sub_Button_Click(object sender, EventArgs e)
        {
            #region Delegates Home Work Qst 04

            TwoNumDelegate twoNumDelegate = Sub;
            int num2 = twoNumDelegate(5, 2);

            #endregion
        }
    }
}
