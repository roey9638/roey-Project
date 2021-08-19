using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_08
{
    class Program
    {


        static void Main(string[] args)
        {
            #region שיעור קודם תרגולים
            //תרגולים Qst 01
            BuildSenrence("hey", "bye", "see ya");
            #endregion

            #region תרגול
            //BankAcount bank = new BankAcount();
            //bank.bankName = "Bankrom";
            //bank.accountNum = 123;
            //bank.balance = 20000;
            #endregion
        }

        #region תרגולים שיעור קודם
        //תרגולים Qst 01
        public static string BuildSenrence(params string[] names)
        {
            string sentence = "";

            for (int i = 0; i < names.Length; i++)
            {
                sentence = names[i] + " ";
            }

            return sentence;
        }


        //Qst 02 Part B. Stcukk

        public static void PrintNameAndAge(params Person[] p1)
        {
            for (int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i].name);
                //p1.IncreaseAge();
            }
        }

    }

    //תרגולים Qst 02
    class Person
    {
        public int age;
        public string name;

        //A. Part
        public void IncreaseAge(Person person)
        {
            person.age++;

        }

        //B. Part is in the Program class
    }
    #endregion

        #region תרגול


    class BankAcount
    {
        private string bankName;
        private int accountNum;
        private int balance;

        public BankAcount(string name, int account, int balance)
        {
            bankName = name;
            accountNum = account;
            this.balance = balance;
        }

        public void WithDrawOrDeposit(double balance)
        {
            this.balance = (int)balance;
        }

        public string GetAccountDetails()
        {



            return bankName;
        }

    }



    class NewPerson
    {
        private string name;
        private int id;
        private static int numPepole;

        public NewPerson(string name , int id)
        {
            this.name = name;
            this.id = id;
            numPepole++;
        }

        public static void ChangeName(NewPerson person1 , string newName)
        {
            person1.name = newName;
        }

    }

    #endregion




}
