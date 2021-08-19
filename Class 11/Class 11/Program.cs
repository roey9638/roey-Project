using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Struct Qst 07

            Carstruct cs3;
            cs3.model = "mazda";
            cs3.color = "black";
            cs3.year = 2021;
            Console.WriteLine(cs3.model);

            ref Carstruct cs4 = ref cs3;

            cs4.color = "yellow";

            #endregion
        }
    }

    #region Struct Qst 07

    struct Carstruct
    {
        public string model;
        public string color;
        public int year;

        public Carstruct(string model , string color , int year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }
    }
    #endregion
}
