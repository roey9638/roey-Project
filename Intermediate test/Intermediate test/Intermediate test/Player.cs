using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_test
{
    public class Player
    {
        ConsoleKeyInfo getKey;

        int curLeft;
        int curTop;
        private bool[,] isPixleUsed;


        public void GetMovement()
        {
            while (true)
            {
                PlayerMovement();
            }

        }


        public void SetConsole(int width, int height)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            Console.ForegroundColor = ConsoleColor.White;

            //Here I'm initializing My [int] Variable [curLeft] to be [equal / (=)] to a [Random number] with the (size) of [width] which means new Random().Next(0 ,width)
            //Whats been pass into my [width] Variable is inside the [Program] class.
            curLeft = new Random().Next(width);

            //Here I'm initializing My [int] Variable [curLeft] to be [equal / (=)] to a [Random number] with the (size) of [height] which means new Random().Next(0 ,width)
            //Whats been pass into my [width] Variable is inside the [Program] class.
            curTop = new Random().Next(height);

            //Here I'm setting the size of my [2D array (bool)]. The [width] and the [height] are Initialized int the [Program] class.
            isPixleUsed = new bool[width, height];

            //Here I'm Spawning the [Player (*)] for the first time
            Move(curLeft, curTop);

            //Here im setting my [array (bool)] at the [Positin] ( [width - 1, height - 1] ) Because it's (0) based. Continue Down VV.
            //And it will be [equal / (=)] to [true]. Because we [Initialized] him the first time with the [Function] [Move(curLeft, curTop)]. One Line Above ^^
            isPixleUsed[width - 1, height - 1] = true;

        }


        private void PlayerMovement()
        {
            getKey = Console.ReadKey(true);

            switch (getKey.Key)
            {
                case ConsoleKey.UpArrow:
                    Move(curLeft, curTop - 1);
                    break;

                case ConsoleKey.DownArrow:
                    Move(curLeft, curTop + 1);
                    break;

                case ConsoleKey.RightArrow:
                    Move(curLeft + 1, curTop);
                    break;

                case ConsoleKey.LeftArrow:
                    Move(curLeft - 1, curTop);
                    break;


            }
        }

        private void Move(int newLeft, int newTop)
        {
            //Here I'm checking if my [newLeft] which is the [Player Position] On the (x) is [lower / <] then my [Console.WindowWidth] which [width means (x)]. Continue Down
            //And I'm also Checking if my [newLeft] [Player Position] On the (x) is bigger then (0).
            //Now I'm checking if my [newTop] which is the [Player Position] On the (y) is [lower / <] then my [Console.WindowHeight] which [Height means (y)]. Continue Down
            //And I'm also Checking if my [newTop] [Player Position] On the (y) is bigger then (0).
            if (newLeft < Console.WindowWidth && newLeft > 0 && newTop < Console.WindowHeight && newTop > 0)
            {
                //Here my checking if [isPixleUsed[newLeft, newTop]] is [true] which means there [*] been [Drawn] there That [Pixle] is taken. Continue Down VV
                //And the [Player] hit that place that been [Drawn] [*] So we want to [Restart] The [Game]. If not it will do the --> [else].
                if (isPixleUsed[newLeft - 1, newTop - 1])
                {
                    //Here i need to do that it wil [Restart] The [Console / "Game"].
                }
                else
                {
                    //Here I'm setting my [CursorPosition] on the [Previous] [Postion] that been [Drawn].
                    Console.SetCursorPosition(curLeft, curTop);
                    //Here I'm setting the [Previous] [Postion] that been [Drawn] the [*] to [Blue].
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("*");

                    //Here I'm setting the [Current] [Postion] that been [Drawn] the [*] to [White].
                    Console.ForegroundColor = ConsoleColor.White;
                    //Here I'm setting my [CursorPosition] on the [Current] [Postion] To [Draw] new one with the color [White].
                    Console.SetCursorPosition(newLeft, newTop);
                    Console.Write("*");

                    //Here I'm setting every time afte I [Draw] The [White] [*] From [One or Two Lines Above]. we [set] the ( isPixleUsed[newLeft, newTop] ) into [true].
                    isPixleUsed[newLeft - 1, newTop - 1] = true;

                    //[Maybe Not True .Not Explained Correctly] --> Then after We [Change] The [*] To [White] we [Update] [curLeft] to be [equal / (=)] to [newLeft]. Continue Down VV
                    //[Maybe Not True. Not Explained Correctly] --> For The Next Time We want to color the [*] To [Blue]. The same For the [curTop] that [equal / (=)] to [newTop].
                    //[Maybe This True] --> We [Update] [curLeft] to be [equal / (=)] to [newLeft] which is The [Current Position] The same For the [curTop] that [equal / (=)] to [newTop].
                    curLeft = newLeft;
                    curTop = newTop;
                }
            }
        }
    }

}
