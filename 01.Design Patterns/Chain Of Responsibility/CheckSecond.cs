using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    class CheckSecond : CarWorkShop
    {
        public override void HandleRequest(int check)
        {
            if (check > 6)
            {
                Console.WriteLine("Check 2 was successful");
            }
            else
            {
                Console.WriteLine("The test 2 was Unsuccessful Going to Check 3");
                int rnd = new Random().Next(1, 11);
                if (next != null)
                {
                    next.HandleRequest(rnd);
                }
            }
        }
    }
}
