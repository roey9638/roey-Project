using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class User
    {
        public string UserName = "elad";

        public int password = 1234;

    }

    class Login
    {
        public event DelegateLogin delegateLogin;

        public void TryLogin()
        {
            Console.WriteLine("Please Enter UserName");
            string userName = Console.ReadLine();
            Console.WriteLine("Please Enter Password");
            int password = Convert.ToInt32(Console.ReadLine());

            User user = new User();

            if(user.UserName == userName && user.password == password)
            {
                delegateLogin += OnSuccessLoginEvent;
                delegateLogin();
            }
            else
            {
                delegateLogin += OnFailedLoginEvent;
                delegateLogin();
            }
        }

        private void OnSuccessLoginEvent()
        {
            Console.WriteLine("User name does not exist");
        }

        private void OnFailedLoginEvent()
        {
            Console.WriteLine("User name does not exist");
        }
    }
}
