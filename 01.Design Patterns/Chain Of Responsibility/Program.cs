using System;

namespace Chain_Of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CarWorkShop check1 = new CheckFirst();
            CarWorkShop check2 = new CheckSecond();
            CarWorkShop check3 = new CheckThird();
            CarWorkShop check4 = new CheckFourth();

            check1.SetNext(check2);
            check2.SetNext(check3);
            check3.SetNext(check4);
            check4.SetNext(null);

            //Check 1
            int rnd1 = new Random().Next(1, 11);
            check1.HandleRequest(rnd1);
            Console.WriteLine(" ");
          

        }
    }
}
