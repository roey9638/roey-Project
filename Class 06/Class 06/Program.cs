using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //[Classes] Class Computer Qst 08
            #region Qst 08 Classes

            Computer computer = new Computer();

            computer.tellMePrice(500);

            computer.tellMeScreenSize(25);

            computer.turndOff();

            computer.turndOn();

            computer.GetNumOfProcessor();

            #endregion

            //[Classes] Class Table Qst 09
            #region Qst 09 Classes

            Table table = new Table
            {
                _numsLegs = 4,
                _color = "brown",
                _woodKind = "alon"
            };
            #endregion

            //[Constructor] Class Car Qst 07 
            #region Qst 07 Constructor

            Car myCar = new Car("ford");

            myCar.GetBrand();

            #endregion

            //[Constructor] Class Car Qst 09 
            #region Qst 09 Constructor

            //A. Part
            Console.WriteLine("Enter length of array");
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            string[] array1 = new string[lengthArr];


            //B. Part
            string name;
            int age;
            Random rnd = new Random();
            for (int i = 0; i < lengthArr; i++)
            {
                //G. Part
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();

                //F. Part And //G. Part
                Console.WriteLine("Enter Random age");
                age = rnd.Next(1, 100);

                Person person = new Person(name,age);

                array1[i] = person._name;

                //C. Part And H. Part
                Console.WriteLine("Print name");

                Console.WriteLine("Name: " + array1[i] + " " + "Age: " + " " + age);
            }

            //C. Part
            //for (int i = 0; i < lengthArr; i++)
            //{
            //    Console.WriteLine("Print name");

            //    Console.WriteLine("Name: " + " " + array1[i] + "Age: " + " " + age);
            //    Console.WriteLine(array1[i]);
            //}

            //Qst 09 D. Part is Down in the Class Car.

            //E. Part
            Console.WriteLine("Reset length of array");
            array1 = new string[lengthArr];

            Console.WriteLine("New length of array");
            int[] array2 = new int[lengthArr];


            //F. Part
            //The Part is inside the for loop Under the (B. Part) its the [age = rnd.Next(1, 100)].

            //G. Part
            //The Part is inside the for loop Under the (B. Part) its the [age = rnd.Next(1, 100)].


            #endregion

            //[Constructor] Class ConsolePlus Qst 10
            //B. Part
            string Chain = "5" + 5 + "5";
            ConsolePlus plus = new ConsolePlus(Chain);

            //C. Part
            int getNum1 = 5;
            int getNum2 = 5;
            ConsolePlus plusTwo = new ConsolePlus(Chain , getNum1 , getNum2);


        }
    }

    //[Classes] Class Computer Qst 08
    class Computer
    {

        #region Qst 08 Classes

        string _model;
        int _price;
        int _numOfProcessor;
        float _screenSize;
        bool isTurnOn;

        public void tellMePrice(int getPrice)
        {
            _price = getPrice;
        }


        public void tellMeScreenSize(float sizeScreen)
        {
            _screenSize = sizeScreen;
        }

        public void turndOff()
        {
            isTurnOn = false;
        }

        public void turndOn()
        {
            isTurnOn = true;
        }

        public void GetNumOfProcessor()
        {
            _numOfProcessor = 2;
        }

        #endregion

    }


    //[Classes] Class Table Qst 09
    class Table
    {
        #region Qst 09 Classes

        public int _numsLegs;
        public string _color;
        public string _woodKind;

        public Table()
        {
            _numsLegs = 4;
            _color = "brown";
            _woodKind = "Alon";
        }


        public Table(int legs , string color , string wood)
        {
            _numsLegs = legs;
            _color = color;
            _woodKind = wood;
        }

        #endregion

    }


    //[Classes] Qst 10
    class rectangle
    {
        #region Qst 10 Classes

        double _scope;
        double _area;

        public rectangle(int scope, int area)
        {
            GetScope(scope, area);

            GetArea(scope, area);
        }

        public void GetScope(double Scope, double Area)
        {
            _scope = Scope;
            _area = Area;
        }

        public void GetArea(double _Scope, double _Area)
        {
            _scope = _Scope;
            _area = _Area;
        }

        #endregion

    }


    //[Constructor] Class Car Qst 07
    class Car
    {

        string _carBrand;

        public Car(string brand)
        {
            _carBrand = brand;
        }

        public string GetBrand()
        {
            return _carBrand;
        }

    }


    //[Constructor] Class ConsolePlus Qst 08
    class ConsolePlus
    {
        string _chain;

        //A. Part
        public ConsolePlus()
        {
            Console.WriteLine("Default");
        }

        //B. Part its also on top in the bottom [Main] Function.
        public ConsolePlus(string chain)
        {
            _chain = chain;
            Console.WriteLine(_chain);
        }

        //C. Part its also on top in the bottom [Main] Function. And //D. Part
        public ConsolePlus(string ChainName , int num1 , int num2) : this (ChainName)
        {
            Console.WriteLine(num1 + num2);
        }

        //D. Part is With C.Part
        
    }


    //[Constructor] Class Car Qst 09 
    class Person
    {
        public string _name;
        public int _age;
       

        public Person(string name)
        {
            _name = name;
        }

        //Qst 09 D. Part
        public Person(string name , int Age) : this(name)
        {
            _age = Age;
        }

        
    }


}
