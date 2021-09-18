using System;
using System.Collections.Generic;

namespace Intermediate_test
{
    class Program
    {
        private static List<BaseShape> shapes;
        private static int printShapes;
        private static Random rnd;


        static void Main(string[] args)
        {
            //Here Im declaring how many [Shapes] to print.
            printShapes = 4;

            //Here Im setting What will be m My [Left] [Propety] in my [Point Struct] will be [ new Random().Next(80) ].
            //And My [Top] [Propety] in my [Point Struct] will be [ new Random().Next(25) ].
            Point p = new Point(new Random().Next(80), new Random().Next(25));

            //The Explanation for [p] is Above ^^. Second line int The [Main].
            //Here Im Passing into my [LineShape] [Constructor] The [p] which is a [struct] and The [char] which here is [=].The Continuation to Explanation is in the [LineShape] Class.
            LineShape line = new LineShape(p , '=');

            //The Explanation for [p] is Above ^^. Second line int The [Main].
            //Here Im Passing into my [LineShape] [Constructor] The [p] which is a [struct] and The [char] which here is [=].The Continuation to Explanation is in the [TriangleShape] Class.
            TriangleShape triangle = new TriangleShape(p , '^');

            //The Explanation for [p] is Above ^^. Second line int The [Main].
            //Here Im Passing into my [LineShape] [Constructor] The [p] which is a [struct] and The [char] which here is [=].The Continuation to Explanation is in the [SquareShape] Class.
            SquareShape square = new SquareShape(p , '#');

            //Here I put in my [List<>] of type [BaseShape] The [instance] We [Created] Above ^^.
            //Every [Class] That [inherits] the [BaseShape] [Class] Can be in the [List<>] of tye [<BaseShape>].
            shapes = new List<BaseShape>()
            {
                line,
                triangle,
                square
            };

            for (int i = 0; i < shapes.Count; i++)
            {
                int size = new Random().Next(shapes.Count);
                Point p2 = new Point(new Random().Next(80), new Random().Next(25));
                shapes[size].PrintShape(); // Maybe Change the [size] with the [i] of the [for loop].
            }


            //Here I'm Moveing The Player
            Player player = new Player();
            player.SetConsole(80, 25);
            player.GetMovement();


        }



    }
}
