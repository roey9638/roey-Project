using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PaidDollars : IPayDollars
    {
        public int Add(int num1, int num2)
        {
            //The [* 3] is because dollars is like [3 שקל] so I thought maybe i need to do (Mul / *) by (3). or maybe i don't need it.
            return (num1 + num2) * 3;
        }

        public int Sub(int num1, int num2)
        {
            return (num1 - num2) * 3;
        }

        public int Div(int num1, int num2)
        {
            return (num1 / num2) * 3;
        }

        public int Mul(int num1, int num2)
        {
            return (num1 * num2) * 3;
        }

        
    }
}
