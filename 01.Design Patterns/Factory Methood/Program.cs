using System;

namespace Factory_Methood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myNewBuisness1 = BuisnessFactory.Creat();

            var myNewBuisness2 = BuisnessFactory2.Creat();
        }
    }
}
