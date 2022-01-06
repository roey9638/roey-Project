using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adapter : IPayDollars
    {
        //I can to thie Becuase the [PaidEuro] [class] inherats the [interface] [IPayEuro].
        private IPayEuro _payEuro = new PaidEuro();

        public int Add(int num1, int num2)
        {
            return _payEuro.Add(num1, num2);
        }

        public int Sub(int num1, int num2)
        {
            return _payEuro.Sub(num1, num2);
        }

        public int Div(int num1, int num2)
        {
            return _payEuro.Div(num1, num2);
        }

        public int Mul(int num1, int num2)
        {
            return _payEuro.Mul(num1, num2);
        }


    }
}
