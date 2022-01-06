using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    class CheckThird : CarWorkShop
    {
        public override void HandleRequest(int check)
        {
            if (check > 6)
            {
                Console.WriteLine("Check 3 was successful");
            }
            else
            {
                Console.WriteLine("The test 3 was Unsuccessful Going to Check 4");
                int rnd = new Random().Next(1, 11);
                if (next != null)
                {
                    next.HandleRequest(rnd);
                }
            }
        }
    }
}
