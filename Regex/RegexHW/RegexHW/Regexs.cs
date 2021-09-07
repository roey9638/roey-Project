using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexHW
{
    public class Regexs
    {
        static string name = "Dana";
        static string name2 = "Jeff";
        static string name3 = "J123456";
        static string name4 = "yyyזזזז";
        static string name5 = "Amber";
        static string name6 = "Bar";
        static string name7 = "Gal Sasson";
        static string num = "5.5";
        static string num2 = "5.555";


        #region Qst 01
        public static bool Check()
        {
            var Check = new Regex(@"^D");

            if (Check.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Qst 02
        public static bool CheckTwo()
        {
            var Check = new Regex(@"[JFD]");

            if (Check.IsMatch(name2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Qst 03
        public static bool CheckThree()
        {
            var Check = new Regex(@"[JFD]\d{6}\w[A-Z]{2}");

            if (Check.IsMatch(name3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Qst 04
        public static void CheckFour()
        {
            var Check = new Regex(@"");
            
            string result =  Regex.Replace(name4, "(y{3}|ז{4)" , " ");
           
        }

        #endregion

        #region Qst 05
        public static void CheckFive()
        {
            var Check = new Regex(@"^[A-Z]");

            bool result = Check.IsMatch(name5);

        }
        #endregion

        #region Qst 06
        public static void CheckSix()
        {
            var Check = new Regex(@"([abc] | [ABC])");

            bool result = Check.IsMatch(name6);

        }
        #endregion

        #region Qst 07

        public static void CheckSeven()
        {
            var Check = new Regex(@"[a-z A-Z]{2,18}[a-z A-Z]{2,18}");

            bool result = Check.IsMatch(name7);

        }

        #endregion

        #region Qst 08

        public static void CheckEight()
        {
            var Check = new Regex(@"[0-9]{1,}\.{1}[0-9]{1,}");

            bool result = Check.IsMatch(num);

        }

        #endregion

        #region Qst 09

        public static void CheckNine()
        {
            var Check = new Regex(@"[0-9]{1,}\.{1}[0-9]{3}$");

            bool result = Check.IsMatch(num2);

        }

        #endregion

        #region Qst 10

        public static void CheckTen()
        {
            var Check = new Regex(@"[a-z A-Z 0-9]\@(gmail|GMAIL|yahoo|YAHOO)\.\D{3,}$");

            bool result = Check.IsMatch(num2);

        }

        #endregion

    }
}
