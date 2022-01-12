using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VacationBuilder lowCost = new LowCost();
            lowCost.ConsructVacation();
            var lowVacation = lowCost.GetVacation();
            Console.WriteLine(lowVacation);

            Console.WriteLine(" ");
            Console.WriteLine("High Cost Vacation -----------------------------------------------------------------------------");
            Console.WriteLine(" ");

            VacationBuilder highCost = new HighCost();
            highCost.ConsructVacation();
            var highVacation = highCost.GetVacation();
            Console.WriteLine(highVacation);
        }
    }
}
