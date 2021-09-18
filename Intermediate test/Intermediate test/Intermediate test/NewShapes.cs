using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_test
{

    class SquareShape : BaseShape
    {
        //Squre Shape
        char TheChar = '#';
        public static Random rnd = new Random();
        static int rnd2 = rnd.Next(1, 10);
        public string[,] squareShape = new string[rnd2, rnd2];

        public SquareShape(Point leftTop, char theChar) : base(leftTop, theChar)
        {
            //Here I'm calling the [base] Which is the [Point] which is [Struct] and not [class]. in the [Struct] we [take Care] of the [(leftTop, theChar)].
        }

        public override void PrintShape()
        {
            for (int i = 0; i < squareShape.GetLength(0); i++)
            {

                for (int l = 0; l < squareShape.GetLength(1); l++)
                {
                    Console.Write(TheChar + " ");

                }

                Console.WriteLine("");

            }
        }

    }  
    

}
