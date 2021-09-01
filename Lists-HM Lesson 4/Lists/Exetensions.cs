using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lists
{
    static class Exetensions
    {
        #region Qst 01
        public static bool HasLowerChar(this string name)
        {
            foreach (var charr in name)
            {
                if (charr >= 'a' && charr <= 'z')
                {
                    return true;
                }
            }
            return false;
        }
        #endregion


        #region Qst 02
        public static void ReverseCase(this string name)
        {
            string newName = "";
            foreach (var lower in name)
            {
                if (lower >= 'a' && lower <= 'z')
                {
                    newName += Convert.ToString(lower).ToUpper();
                }
                else
                {
                    newName += Convert.ToString(lower).ToLower();
                }
            }
        }
        #endregion

        //Stuck
        #region Qst 03

        //public static string Print(this int num)
        //{
        //    string[] nums1 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" }; 
        //    string[] nums2 = { "teen" , "twenty", "thirty", "fourty", "fivty", "sixty", "siventy", "eighty", "ninty" }; 

        //    if(num >= 0 && num <= 10)
        //    {
        //       return nums1[num];
        //    }
        //    else if (num == 11)
        //    {
        //        return "eleven";
        //    }
        //    else if (num == 12)
        //    {
        //        return "twelve";
        //    }
        //    else if (num == 13)
        //    {
        //        return "therteen";
        //    }
        //    else if (num == 14)
        //    {
        //        return "fourteen";
        //    }
        //}

        #endregion


        #region Qst 04

        public static int MultipleBy(this int number1 , int number2)
        {
            return number1 * number2;
        }

        #endregion


        #region Qst 05

        public static bool IsNull(this object something)
        {
            if(something == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        //Stck
        #region Qst 06

        public static bool IsValidIsraeliIdNumbe(this string id)
        {
            return false;
        }

        #endregion
    }
}
