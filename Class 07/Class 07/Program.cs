using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_07
{
    class Program
    {
        static void Main(string[] args)
        {

            //override,virtual and new ---[HomeWork]---
            //E. Part And F. Part of Qst 03 is here
            #region Qst 03

            Veihcle onlyBase = new Veihcle();
            onlyBase.AddWheel();
            onlyBase.OpenOrClosrRoof();

            Veihcle baseWithCar = new Car();
            baseWithCar.AddWheel();
            baseWithCar.OpenOrClosrRoof();

            Veihcle baseWithMotor = new Motorcycle();
            baseWithMotor.AddWheel();
            baseWithMotor.OpenOrClosrRoof();

            Car onlyCar = new Car();
            onlyCar.AddWheel();
            onlyCar.OpenOrClosrRoof();

            Motorcycle onlyMotor = new Motorcycle();
            onlyMotor.AddWheel();
            onlyMotor.OpenOrClosrRoof();

            #endregion
        }

        //override,virtual and new ---[HomeWork]---
        #region Qst 01

        //A. Part
        //Anyone any [Class] can call this [Function] but if they want to they can also [override] this [Function].
        public virtual void Print()
        {
            Console.WriteLine("Hello");
        }
        //B. Part IS Down there VV.

        #endregion


        //---Home-Work Method&Ctors Overloading---
        #region Qst2

        //[Constructor] [OVerloading] --[Example]--.
        Functions ConstructorOverloading = new Functions();

        #endregion


    }

    #region override,virtual and new ---[HomeWork]---

    //override,virtual and new ---[HomeWork]---
    //B. Part is here
    #region Qst 01
    class Override : Program
    {
        //B.
        //[override] The [Function] From the [Program] [Class] [Above] the [Function] is [Print()].
        public override void Print()
        {
            Console.WriteLine("Good Bye");
        }
    }
    #endregion

    //The [Answer] is In [Qst 01]
    #region Qst 02

    #endregion

    #region Qst 03

    public class Veihcle
    {
        public int wheelNum;
        public string color;
        public bool isRoofOpen = false;

        //A. Part is here
        public virtual void AddWheel()
        {
            wheelNum = Convert.ToInt32(Console.ReadLine());

            if (wheelNum < 4)
            {
                wheelNum++;
            }

            Console.WriteLine(wheelNum);
        }

        //B. Part is here
        public void OpenOrClosrRoof()
        {
            isRoofOpen = true;
        }

        //C. Part And D. Part is Down There VV.

    }

    //C. Part And D. Part is here
    class Car : Veihcle
    {

    }

    //C. Part And D. Part is here
    class Motorcycle : Veihcle
    {
        public override void AddWheel()
        {
            wheelNum = Convert.ToInt32(Console.ReadLine());

            if (wheelNum < 2)
            {
                wheelNum++;
            }

            Veihcle roof = new Veihcle();
            roof.isRoofOpen = true;
            Console.WriteLine("Roof is always Open");

        }
    }

    #endregion

    #endregion


    #region Home-Work Method&Ctors Overloading
    //---Home-Work Method&Ctors Overloading---
    class Functions
    {
        //---Home-Work Method&Ctors Overloading---

        //[Function Overloading] --[Example]--.
        #region Qst 01

        public void FunctionOverloading(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public void FunctionOverloading(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2);
        }
        #endregion


        #region Qst 02 And Os6

        //[Constructor] [OVerloading] --[Example]--.
        //Qst 02 And Qst 06
        public Functions()
        {

        }
        //[Constructor] [OVerloading] --[Example]--.
        //Qst 02 And Qst 06
        public Functions(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        //[Constructor] [OVerloading] --[Example]--.
        //Qst 02 And Qst 06
        public Functions(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2);
        }

        #endregion


        #region Qst 06

        //Qst 06 is with Qst 02

        #endregion
    }

    //---Home-Work Method&Ctors Overloading---
    class Clock
    {
        #region Qst 07

        int mins = 1;
        int hour = 2;
        int seconds = 60;
        int day = 3;
        int temp = 24;

        //A. Part And C. Part is the [seconds]
        public Clock(int mins, int hour, int seconds, int day, int temp)
        {
            mins = this.mins;
            hour = this.hour;
            seconds = this.seconds;
            day = this.day;
            temp = this.temp;
        }

        //B. Part
        public void PrintHourAndMinute()
        {
            Console.WriteLine(mins);
            Console.WriteLine(hour);
        }

        //C.Part is with A. Part


        //D. Part
        public void PrintHourMinuteAndSeconds()
        {
            Console.WriteLine(seconds);
        }


        //E. Part
        public void PrintHourMinutSecondDayAndTemp()
        {
            Console.WriteLine(mins);
            Console.WriteLine(hour);
            Console.WriteLine(seconds);
            Console.WriteLine(day);
            Console.WriteLine(temp);
        }


        //F. Ppart Didnt Understand
        public void PtintDetails()
        {

        }
        #endregion
    }

    //---Home-Work Method&Ctors Overloading---
    #region Qst 08

    class Computer
    {
        public string[] allOpenFiles = new string[5];
        public bool isOn;

        public void TurnOff()
        {
            allOpenFiles = null;
        }

        //A. Part
        public Computer(string[] allOpenFiles)
        {
            isOn = true;
        }

        //B. Part -- Maybe Not Rigth --
        public void TurnOff(bool OnOff)
        {
            if (OnOff == true && allOpenFiles == null || OnOff == false && allOpenFiles == null)
            {
                isOn = false;
            }
            else
            {
                isOn = true;
            }
        }

        //C. Part is Down there VV. Its the [class] [SmartComp].



    }

    //C. Part Qst 08 --> Not Finished [Problems]
    class SmartComp 
    {
        string[] filesInCache;

        public void TurnOff(bool OnOff)
        {
            // if (OnOff == false) 
        }
    }
    #endregion


    #endregion


    //---Home-Work Stack And Heap---

}
