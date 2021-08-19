using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //---[Static HomeWork]-----

            #region Static Qst 04
            Person p1 = new Person(250, 052, "bar" , 1);
            Person.ChangeName(p1, "gal");
            Person.ChangePhone(p1, 520);

            Person[] personArray = new Person[10]; // Last Part
            for (int i = 0; i < personArray.Length; i++)
            {
               //personArray[i];
            }
            #endregion

            //---[Static HomeWork]-----
            #region Qst 03

            //BankAccount bank = new BankAccount
            //{
                //balance = 10,
                //accountNumber = 123,
                //bankName = "daily",
                //balance = 2000000
            //};


            #endregion

        }


        //---[Access Modifiers, const&readonly]---

        #region Qst 04
        ClientsManagment client1 = new ClientsManagment();
        public void AddNewNameToList(string newName)
        {          
            client1.counter = int.Parse(newName);
        }

        public void AddNewAgeToList(int newAge)
        {
            client1.counter = newAge;
        }

        public void AddNewBoolToList(bool isVegetarian)
        {
            client1.counter = Convert.ToInt32(isVegetarian);
        }
        #endregion

    }

    //---[Static HomeWork]-----

    #region Static Qst 04

    class Person
    {
        private readonly int id;
        private int phone;
        private string name;
        private static int numberOfPersons = 0;


        public Person()
        {

        }

        public Person(int id, int phone, string name, int numOfPersons)
        {
            //this.id = id;
            this.phone = phone;
            this.name = name;
            this.id = numOfPersons;

        }

        public static void ChangeName(Person person1 , string GetName)
        {
            person1.name = GetName;
        }

        public static void ChangePhone(Person person2 , int GetPhone)
        {
            person2.phone = GetPhone;
        }
        
    }


    #endregion

    //Stuck
    #region Static Qst 05

    class User
    {
        public string password;
        public string userNam;
        public bool isLogin;

        public enum permission
        {
            on,
        };

    }

    #endregion


    //---[Access Modifiers, const&readonly]---


    #region Qst 04
    
    public class ClientsManagment
    {
        public string[] customersNames = new string[10];
        public int[] customersAges = new int[10];
        public bool[] isVegan = new bool[10];
        public int counter = 0;

        public ClientsManagment()
        {

        }

        public ClientsManagment(string[] customersNames , int[] customersAges , bool[] isVegan , int counter)
        {

        }
      
    }

    #endregion


}
