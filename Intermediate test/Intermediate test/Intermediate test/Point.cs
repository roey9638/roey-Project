using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_test
{
    struct Point
    {
        public int Left { get; set; }
        public int Top { get; set; }

        //Whats been [Pass] into here is from the [Program] [class].
        //First We [Pass] the [left, top] into the [class] [Shape] which can be [LineShape ,TriangleShape, NewShape/SquareShape]. Continue Down VV.
        //Then over there in there [Constructor] we do [ base(leftTop, theChar ] which sends into [Here] [Constructor]. The [Point] [Constructor].
        public Point(int left, int top)
        {
            Left = left;
            Top = top;
        }

    }
}
