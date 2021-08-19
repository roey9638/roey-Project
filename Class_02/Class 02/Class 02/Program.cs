using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Mission no num

            /*
            Console.WriteLine("Plese enter a num bigger then 3");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < num1 * 2; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
            */
            #endregion



            #region Loops Mission 01
            /*
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();


            */
            #endregion



            #region Loops Mission 02
            /*
            Console.WriteLine("Pick 5 numbers");
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;
            }

            Console.WriteLine(sum / 5);

            Console.ReadKey();
            */
            #endregion



            #region Loops Mission 03

            /*
            for (int i = 9; i > 0; i--)
            {
                for (int l = i; l >= 0; l--)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }

            */

            #endregion



            #region Loops Mission 04
            /*
            do
            {
                Console.WriteLine("Please Pick 2 Numbers");

                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Num1 is = " + " " + num1);

                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Num2 is: = " + " " + num2);

                if (num1 == 0 || num2 == 0)
                {
                    continue;
                }
                else if (num1 < 0 || num2 < 0)
                {
                    break;
                }

                int result = num1 * num2;

                Console.WriteLine("The result is = " + " " + result);
            }
            while (true);

            */
            #endregion



            #region Last Mission
            /*
            for (int i = 0; i < 10; i++)
            {

                if (i == 0)
                {
                    continue;
                }
                else if (i > 10)
                {
                    break;
                }

                Console.WriteLine(i);

                Console.ReadKey();


            */
            #endregion

        }

    }
}

