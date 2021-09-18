using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_test
{
    class Player2
    {
        public int PosX { get; set; }
        public int PosY { get; set; }



        public Player2(int x, int y)
        {

            PosX = x;
            PosY = y;
        }



        public static void Movement(int newLeft, int newTop)
        {
            var key = Console.ReadKey(true);


            switch (key.Key)
            {

                case ConsoleKey.UpArrow:
                    {
                       if (newLeft < Console.WindowWidth && newLeft > 0 && newTop < Console.WindowHeight && newTop > 0)
                        {

                            Console.SetCursorPosition(newLeft, newTop);
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("*");

                            newTop = newTop - 1;
                            Console.SetCursorPosition(newLeft, newTop);

                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("*");
                        }
                    }
                    break;


                case ConsoleKey.DownArrow:
                    {

                        Console.SetCursorPosition(newLeft, newTop);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("*");

                        newTop = newTop + 1;
                        Console.SetCursorPosition(newLeft, newTop);

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("*");
                    }
                    break;


                case ConsoleKey.RightArrow:
                    {

                        Console.SetCursorPosition(newLeft, newTop);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("*");
                        newLeft = newLeft + 1;
                        Console.SetCursorPosition(newLeft, newTop);

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("*");
                    }
                    break;


                case ConsoleKey.LeftArrow:
                    {

                        Console.SetCursorPosition(newLeft, newTop);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("*");
                        newLeft = newLeft - 1;
                        Console.SetCursorPosition(newLeft, newTop);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("*");
                    }
                    break;

            }
            Movement(newLeft, newTop);
        }

    }
}
