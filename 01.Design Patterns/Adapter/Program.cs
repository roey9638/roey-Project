using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPayDollars payDollars = new PaidDollars();
            int num1 = 5;
            int num2 = 5;
            PrintResults(payDollars , num1 , num2);

            //----Will Not Compile-----
            //IPayEuro payEuro = new PaidEuro();
            //int num3 = 5;
            //int num4 = 5;
            //PrintResults(payEuro, num3, num4);

            Console.WriteLine("--------------Euro--------------------");

            IPayDollars adapterCalc = new Adapter();
            int num5 = 5;
            int num6 = 5;
            PrintResults(adapterCalc, num5, num6);
        }

        public static void PrintResults(IPayDollars calculator, int num1 , int num2)
        {
            Console.WriteLine(calculator.Add(num1 , num2));

            Console.WriteLine(calculator.Sub(num1 , num2));

            Console.WriteLine(calculator.Div(num1 , num2));

            Console.WriteLine(calculator.Mul(num1 , num2));
        }
    }
}
