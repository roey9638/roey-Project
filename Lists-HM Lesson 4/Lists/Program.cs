using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{

    static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //List Home Work!!!
            #region Qst 01

            //List<Student> list = new List<Student>();


            //list.Add(new Student("Jonathan" , "Something" , 20));
            //list.Add(new Student("Elad" , "Kantor" , 25));
            //list.Add(new Student("daniel" , "Last" , 19));


            ////---[Qst01 .A]--- Sorting The List By [Last Name]
            ////list.Sort();
            //SortLastName lastName = new SortLastName();
            //list.Sort(lastName);


            ////---[Qst01 .B]--- Sorting The List By [Grade]
            //SortByGrade gradeSort = new SortByGrade();
            //list.Sort(gradeSort);


            ////---[Qst01 .C]--- Sorting The List By [Last Name] then [First Name]
            //SortLastAndFirstName lastFirst = new SortLastAndFirstName();
            //list.Sort(lastFirst);

            #endregion


            #region Qst 02

            //List<Temperatures> temps = new List<Temperatures>();

            //temps.Add(new Temperatures("Nateneya" , 16 , 35 , 15));
            //temps.Add(new Temperatures("Tel Aviv" , 26 , 30 , 20));
            //temps.Add(new Temperatures("Hadera" , 9 , 19 , 23));

            ////---[Qst 02 A.]---
            //SortCity city = new SortCity();
            //temps.Sort(city);

            ////---[Qst 02 B.]---
            //SortCityDate date = new SortCityDate();
            //temps.Sort(date);

            ////---[Qst 02 C.]---
            //SortByTempThenCity tempCity = new SortByTempThenCity();
            //temps.Sort(tempCity);

            ////---[Qst 02 D.]---
            //SortByMoistureThenDegreesThenCity Moisturee = new SortByMoistureThenDegreesThenCity();
            //temps.Sort(Moisturee);

            #endregion


            //Exetensions Home Work!!!

            #region Qst 01

            //string name = "Gal";
            //var maybe = name.HasLowerChar();

            #endregion


            #region Qst 02

            //Answer is inside the [Exetensions Script].

            #endregion


            #region Qst 03

            //Stuck

            #endregion


            #region Qst 04

            //Answer is in the [Form1] with the [Buttons] in button1_Click.

            #endregion


            #region Qst 05

            //Answer is in the [Form1] with the [Buttons] in button2_Click.

            #endregion


            #region Qst 06

            string ID = "207153545";
            ID.IsValidIsraeliIdNumbe();

            #endregion


            #region Example class
            //List<Student> list = new List<Student>();

            //list.Remove(new Student("Gal"));
            //list.Remove(new Student("moshe"));
            //list.Remove(new Student("haim"));
            #endregion
        }
    }
}
