using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PaidEuro : IPayEuro
    {
        public int Add(int num1, int num2)
        {
            //The [* 3] is because Euro is like [4 שקל] so I thought maybe i need to do (Mul / *) by (3). or maybe i don't need it.
            return (num1 + num2) * 4;
        }

        public int Sub(int num1, int num2)
        {
            return (num1 - num2) * 4;
        }

        public int Div(int num1, int num2)
        {
            return (num1 / num2) * 4;
        }

        public int Mul(int num1, int num2)
        {
            return (num1 * num2) * 4;
        }
    }
}
