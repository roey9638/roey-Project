using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_WindowsForm
{
    public partial class Form1 : Form
    {
        client client = new client();
        Person p = new Person(); // This One is Working as Well
        
        public Form1()
        {
            InitializeComponent();
            client.delegateLongName += NameHandler;
            //p.delegateLongName += NameHandler; - This One is Working as Well
            p.delegateLuckyNum += NumHandler;
            
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
           
        }

        #region Events HM Qst 01
        private void save_btn_Click(object sender, EventArgs e)
        {
            client.Name = txtName.Text;
            //p.Name = txtName.Text; - This One is Working as Well
        }

        private void NameHandler()
        {
            MessageBox.Show($"Hey {client.name} your Name is to long ");
        }
        #endregion

        private void Check_Click(object sender, EventArgs e)
        {
            p.Num = Convert.ToInt32(txtNum.Text);
        }

        private void NumHandler()
        {
            MessageBox.Show("LuckyNumberWasEntered");
        }

        private void btnEnterUser_Click(object sender, EventArgs e)
        {
            //Qst 05 here
        }

        private void UserHandlerSuccess()
        {
            MessageBox.Show("You Got in");
        }

        private void UserHandlerFailed()
        {
            MessageBox.Show("You failed to Get in");
        }
    }
}
