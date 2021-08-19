using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_05
{
    class Program
    {
        //Mission 08 --> Variables
        //public static int number = Convert.ToInt32(Console.ReadLine());

        


        static void Main(string[] args)
        {

            //Mission 01
            /*
            Console.WriteLine("Pick a Name");

            for (int i = 0; i < 10; i++)
            {

                string pickname = Console.ReadLine();

                Mission1(pickname);

            }
            */

            //Mission 02
            /*
            int[] mission02 = { 1, 2, 3, 4, 5 };

            Mission2(mission02);
            */

            //Mission 03
            /*
            int Num1Mission03 = Convert.ToInt32(Console.ReadLine());
            int Num2Mission03 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Mission3(Num1Mission03, Num2Mission03));
            */









            //Home Work..........................................



            //Qst 08..

            //Console.WriteLine("Heres Qst 01");
            //Mission08(number);

            //Qst09..

            //Mission09();


            //Qst 10..

            //Mission10();


            //Qst 11..

            //int num = Convert.ToInt32(Console.ReadLine());
            //Mission11(num);


            //Qst 12..

            //int[] Number12 = { 17, 13, 9, 4, 2 };
            //Mission12(Number12);


            //Qst 13..

            //int[] array13 = new int[10];
            //int[] secondArray13 = new int[5];

            ////// Mission13(array13, secondArray13);


            //Qst14..
            //int[,] creatMatrix = BuildRandomMatrixMission14();
            //Mission14(BuildRandomMatrixMission14());


            //Qst 15..


            //int[] PrintArray15 = {100,5,2,15,10,-5};

            //SortMission15(PrintArray15);

            //PrintMission15(PrintArray15);



        }

        //תרגולים

        public static void Mission1(string name)
        {
            /*
            Console.WriteLine("Heres The Name" + " " + name);
            */
        }


        public static void Mission2(int[] ArrayNums)
        {
            /*
            for (int i = 0; i < ArrayNums.Length; i++)
            {
                PrintMission2(i);
            }
            */
        }


        public static void PrintMission2(int num)
        {
            /*
            Console.WriteLine(num);
            */
        }


        public static int Mission3(int num1, int num2)
        {

            int result = (num1 * num2);

            return result;

        }



        //Home Work...........................................................................

        public static void Mission08(int nums)
        {
          /*

            switch (number)
            {
                case 1:

                    Console.WriteLine("One");
                    break;

                case 2:

                    Console.WriteLine("Two");
                    break;

                case 3:

                    Console.WriteLine("Three");
                    break;

                case 4:

                    Console.WriteLine("Four");
                    break;

                case 5:

                    Console.WriteLine("Five");
                    break;

                case 6:

                    Console.WriteLine("Six");
                    break;

                case 7:

                    Console.WriteLine("Seven");
                    break;

                case 8:

                    Console.WriteLine("Eigth");
                    break;

                case 9:

                    Console.WriteLine("Nine");
                    break;

                case 10:

                    Console.WriteLine("Ten");
                    break;

            }

            Console.ReadKey();

         */
        }   //Done!!!




        public static bool Mission09()
        {
            /*

            Console.WriteLine("Heres Mission 9 Pick a Number");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
            if (num >= 0 && num <= 10)
            {
                Console.WriteLine("it will return true");

                return true;
            }
            else
            {
                Console.WriteLine("it will return false");

                return false;
            }

            */

        }   //Done!!!


        public static void Mission10(int num) //Didnt Start
        {
            

        }


        private static void Mission11(int number)  
        {
            /*
               if(number % 2 == 0)
               {
                   Console.WriteLine("Is Prime");
               }
               else
               {
                   Console.WriteLine("Is Not Prime");
               }
            */
        }   //Done!!!


        private static void Mission12(int[] array12)
        {
         /*
            for (int i = 0; i < array12.Length; i++)
            {
                int currentNum = array12[i];

                Mission11(currentNum);
            }

         */
        }  //Done!!!

       

        private static void Mission13(int[] array1, int[] array2)  //Didnt Start
        {





        }


        public static int[,] BuildRandomMatrixMission14()     //Didnt UnderStand
        {
            int[,] array14 = new int[10, 10];

            Random rnd = new Random();

            for (int i = 0; i < array14.GetLength(0); i++)
            {
                for (int l = 0; l < array14.GetLength(1); l++)
                {
                    array14[i, l] = rnd.Next(1,10) + 1;
                }
            }

            return array14;
        }

        
        //public static bool Mission14(int[,] matrix)
        //{
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int l = 0; l < matrix.GetLength(1); l++)
        //        {
        //            if(matrix[i,l] == num)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //}

        public static void SortMission15(int[] array1)
        {
            /*
              
                Array.Sort(array1);

            */
        }    //Done!!!

        public static void PrintMission15(int[] array2)
        {
            /*

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            */
        }   //Done!!!
        
    }
}
