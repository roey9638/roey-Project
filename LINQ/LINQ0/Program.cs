using System;
using System.Linq;

namespace LINQ0
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq linq = new Linq();
            //linq.Qst01();
            //linq.Qst02();
        }
    }

    class Linq
    {
        string[] array1 = { "roey", "bar", "daniel", "jonathan", "elad" };

        #region Qst 01
        public void Qst01()
        {
            var query = from name in array1
                        where name.Contains("o")
                        select name;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Qst 02
        public void Qst02()
        {
            int[] array = new int[] { 5, 8, 10, -22, -30, 11 };

            var query1 = array.Where(num1 => num1 >= 0);
            foreach (var item in query1)
            {
                Console.WriteLine( item);
            }
        }
        #endregion
    }
}
