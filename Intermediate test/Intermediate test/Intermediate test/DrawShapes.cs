using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_test
{
    public class DrawShapes
    {
        //Squre Shape
        char TheChar = '#';
        public static Random rnd = new Random();
        static int rnd2 = rnd.Next(1, 10);
        public string[,] squareShape = new string[rnd2, rnd2];

        public int LocationLeftTop { get; set; }
        public bool[,] ShapePosition { get; set; } = new bool[70, 20];



        public void SpawnSqure()
        {          
             LocationLeftTop = rnd.Next(0,60);
             int shapePosTop = rnd.Next(0, 30);

            for (int i = 0; i < squareShape.GetLength(0); i++)
            {
                Console.SetCursorPosition(LocationLeftTop, shapePosTop + i); // Random Place To Print Shapes!!!

                for (int l = 0; l < squareShape.GetLength(1); l++)
                {
                    Console.Write(TheChar + " ");
                    try
                    {
                        ShapePosition[LocationLeftTop + l, shapePosTop + i] = true;
                    }
                    catch
                    {
                        break;
                    }
                }

                Console.WriteLine("");
              
            }

        }
       
    }

    



    class Triangle : DrawShapes
    {
        public Random rnd4 = new Random();

        public char TheThirdChar  = '^';

        public new int LocationLeftTop { get; set; }
        public new bool[,] ShapePosition { get; set; } = new bool[80, 25];





        public void SpawnTriangle()
        {

            LocationLeftTop = rnd4.Next(1, 80);
            int shapepositiontop = rnd4.Next(1, 25);

            for (int i = 0; i < rnd4.Next(1, 10); i++)
            {
                Console.SetCursorPosition(LocationLeftTop, shapepositiontop + i);

                for (int l = 0; l < i + 1; l++)
                {
                    Console.Write(TheThirdChar + " ");
                    try
                    {
                        ShapePosition[LocationLeftTop + l, shapepositiontop + i] = true;
                    }
                    catch
                    {
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }

    }
}
