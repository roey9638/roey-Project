using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_test
{
    class TriangleShape : BaseShape
    {

        public Random rnd4 = new Random();

        public char TheThirdChar = '^';

        public TriangleShape(Point leftTop, char theChar) : base(leftTop, theChar)
        {
            //Here I'm calling the [base] Which is the [Point] which is [Struct] and not [class]. in the [Struct] we [take Care] of the [(leftTop, theChar)].
        }

        public override void PrintShape()
        {
            for (int i = 0; i < rnd4.Next(1, 10); i++)
            {

                for (int l = 0; l < i + 1; l++)
                {
                    Console.Write(TheThirdChar + " ");

                }
                Console.WriteLine("");
            }
        }

        


    }
}
