using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class Mission 01 Arrays
            /*
            int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.WriteLine(nums[i]);
                }
                
            }
            Console.ReadKey();
            */
            #endregion


            #region Cliass Mission 02 Arrays
            /*
            int[] nums2 = new int[10];
            int[] nums3 = new int[10];

            for (int i = 0; i < nums2.Length; i++)
            {        

                int value = Convert.ToInt32(Console.ReadLine());
                int value2 = Convert.ToInt32(Console.ReadLine());
                nums2[i] = value;
                nums3[i] = value2;

                for (int l = 0; l < nums3.Length; l++)
                {
                   
                }
            
            }
            */
            #endregion


            #region Arrays HomeWork 01
            /*
            int[] nums4 = new int[10];

            for (int i = 0; i < nums4.Length; i++)
            {
                int Nums = Convert.ToInt32(Console.ReadLine());

                nums4[i] = Nums;

                Console.Write(nums4[i]);
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            #endregion


            #region Arrays HomeWork 02
            /*
            int[] nums1 = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(nums1[0]);
            Console.WriteLine(nums1[1]);
            Console.WriteLine(nums1[2]);
            Console.WriteLine(nums1[3]);
            Console.WriteLine(nums1[4]);

            Console.ReadKey();
            */
            #endregion


            #region Arrays HomeWork 03
            /*
            int[] Number1 = new int[10];
            int[] Number2 = new int[10];

            for (int i = 0; i < Number1.Length; i++)
            {
                //HomeWork 03 a.
                Number1[i] = Convert.ToInt32(Console.ReadLine());
               

                //HomeWork 03 d.
                Number1 = new int[10] {10 , 9, 8 , 7 , 6 , 5 , 4 , 3 , 2 , 1 };


            }
            for (int i = 0; i < Number1.Length; i++)
            {
                Number2[i] = Number1[i];
            }

            Number1[5] = -1;

            for (int i = 0; i < Number2.Length; i++)
            {
                Console.WriteLine(Number2[i]);
            }
            
            Console.ReadKey();
            */




            #endregion


            #region Arrays HomeWork 04

            /*
            int[] Number3 = new int[10];
            int[] Number4 = new int[10];

            int userNums = Convert.ToInt32(Console.ReadLine());

            //Number3[0] = userNums;
            //Number3[1] = userNums;
            //Number3[2] = userNums;
            //Number3[3] = userNums;
            //Number3[4] = userNums;
            //Number3[5] = userNums;
            //Number3[6] = userNums;
            //Number3[7] = userNums;
            //Number3[8] = userNums;
            //Number3[9] = userNums;

            Number4 = Number3;

            //Number4[0] = Number3[0];
            //Number4[1] = Number3[1];
            //Number4[2] = Number3[2];
            //Number4[3] = Number3[3];
            //Number4[4] = Number3[4];
            //Number4[5] = Number3[5];
            //Number4[5] = Number3[6];
            //Number4[7] = Number3[7];
            //Number4[8] = Number3[8];
            //Number4[9] = Number3[9];

            */
            #endregion


            #region Arrays HomeWork 05
            /*
            int[] Number6 = new int[10];
            int[] Number7 = new int[10];

            for (int i = 0; i < Number6.Length; i++)
            {
                //HomeWork 03 a.
                int pickNums = Convert.ToInt32(Console.ReadLine());

                Number6[i] = pickNums;

                //HomeWork 03 b.
                Number7[i] = Number6[i];

                //HomeWork 03 d.
                Number6 = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };  

                #endregion

            }
            Console.WriteLine(Number7[0]);

            Console.ReadKey();

            */
            #endregion


            #region Arrays HomeWork 06
            /*
            int[] students;

            Console.WriteLine("Please Write how many Students you hav in your class");

            int Num = Convert.ToInt32(Console.ReadLine());

            students = new int[Num];


            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Give the first student a grade");

                students[i] = Convert.ToInt32(Console.ReadLine());

                //[(length זה החלק האחרון שלא הצלחתי להבין -  [לאחר מכן בלולאה נפרדת, רצה על המערך ומחשבת את סכום הציונים ואח"כ את הממוצע(השתמש ב
                //Console.WriteLine("here is the sum");
                //Console.WriteLine(students[i / Num]);
            }
            Console.ReadKey();
            */
            #endregion


            //Lesson 4 Advance Arrays


            //לעשות חזרה
            #region Qst 02 Array Advance
            /*
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int curTries = 0, sumTries = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                while (sumTries + curTries < 30)
                {
                    int num = int.Parse(Console.ReadLine());
                    curTries++;
                    if (Array.IndexOf(intArr, num) == i)
                    {
                        Console.WriteLine($"You Found Item {i + 1} After: {curTries} Tries");
                        sumTries += curTries;
                        curTries = 0;
                        break;
                    }
                    else
                        Console.WriteLine("Try Again");
                }

                if (sumTries + curTries >= 30)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
            */
            #endregion


            //לעשות חזרה
            #region Qst 03 Array Advance
            
            Console.WriteLine("here Qst 3");

            int[,] twoDimIntArr = new int[5, 5];

            Random rnd = new Random();

            for (int i = 0; i < twoDimIntArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimIntArr.GetLength(1); j++)
                {
                    twoDimIntArr[i, j] = rnd.Next();
                }
            }

            int num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < twoDimIntArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimIntArr.GetLength(1); j++)
                {
                    if (twoDimIntArr[i, j] == num1)
                    {
                        Console.WriteLine($"i = {i}. j = {j}");
                    }
                }
            }

            Console.ReadKey();

            
            #endregion



            #region Qst 04 Array Advance
            /*
            int[,] num = new int[10, 10];


            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = (i + 1) * (j + 1);

                    Console.Write(num[i,j] + " ");

                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
            */

            #endregion


            //Didnt Understand
            #region Qst 05 Array Advance
            /*
            int[,] array5 = new int[3, 3];

            array5[0, 0] = 1; 
            array5[0, 1] = 0; 
            array5[0, 2] = 1;

            array5[1, 0] = 1;
            array5[1, 1] = 1;
            array5[1, 2] = 0;

            array5[2, 0] = 0;
            array5[2, 1] = 0;
            array5[2, 2] = 1;



            for (int i = 0; i < array5.GetLength(0); i++)
            {
                for (int l = 0; l < array5.GetLength(1); l++)
                {
                    Console.WriteLine("Please enter a num");

                    int num = Convert.ToInt32(Console.ReadLine());


                    if(num == array5[i, l])
                    {
                        Console.WriteLine("boom");

                        array5[i, l] = 0; 
                    }
                    else
                    {
                        Console.WriteLine("miss");

                    }

                    Console.WriteLine();
                }
            }

            Console.ReadKey();

            */
            #endregion



            #region Qst 06 Array Advance
            /*
            int[,] array2 = new int[5, 5];

            Console.WriteLine("This is Qst 6 Please Enter a Number ");

            int wave = 1;

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                Console.WriteLine("Now wave" + " " + " = " + (wave++) + " ");

                Console.WriteLine();

                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Here the Result = " + " ");

                    Console.WriteLine(array2[i, j]);
                }

                Console.WriteLine();

            }
            */
            #endregion



            #region Qst 07 Array Advance
            /*
            int[,] a = new int[6, 4];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();              
            }
            Console.ReadLine();
            */
            #endregion



            #region Qst 08 Array Advance
            /*
            int[][] jagArray1 = new int[2][];

            jagArray1[0] = new int[5];
            jagArray1[1] = new int[5];

             Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < jagArray1.Length; i++)
            {
                for (int l = 0; l < jagArray1[i].Length; l++)
                {
                    jagArray1[i][l] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.ReadKey();

            */
            #endregion


            #region Qst 09 Array Advance
            /*

            Console.WriteLine("Please enter how many classes there is");

            int classes = Convert.ToInt32(Console.ReadLine());// Pick how many classes

            int[][] classesArray = new int[classes][]; //How Many Classes

            int  sizeOfCurrentClass; // size Of Current Class

            for (int i = 0; i < classesArray.Length; i++)
            {
                Console.WriteLine("Please enter how many kids in class");

                sizeOfCurrentClass = Convert.ToInt32(Console.ReadLine()); // here im chosing how many kids in class

                classesArray[i] = new int[sizeOfCurrentClass]; // here im puting the [size Of Current Class] in the first class [classesArray[i]] [i = 0] at the start so its the first [class/array]

                for (int l = 0; l < sizeOfCurrentClass; l++) //// here im giving a [score] for each [kid] in the [size Of Current Class].
                {
                    classesArray[i][l] = int.Parse(Console.ReadLine()); // here im giving a [score] for the first [class which is i] and [i = 0] and the first kids in the [class] which is [l] and [l = 0].

                   // Console.WriteLine(classesArray[i][l] + " "); // here im printing the [score] the score of the first kid in the first class of the array.
                }
            }

            int curSum, maxAvg = 0, maxIndex = 0;

            for (int i = 0; i < classesArray.Length; i++)
            {
                curSum = 0;

                for (int j = 0; j < classesArray[i].Length; j++)
                {
                    curSum += classesArray[i][j];
                }

                if (curSum / classesArray[i].Length > maxAvg)
                {
                    maxAvg = curSum / classesArray[i].Length;

                    maxIndex = i;
                }
            }
              Console.WriteLine("Higher Avg({0}) Its Of Class Number: {1}", maxAvg, maxIndex);

            */
            #endregion

        }


    }
}



