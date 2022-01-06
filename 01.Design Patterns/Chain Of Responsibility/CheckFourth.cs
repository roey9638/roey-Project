using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    class CheckFourth : CarWorkShop
    {
        public override void HandleRequest(int check)
        {
            if (check > 6)
            {
                Console.WriteLine("Check 4 was successful");
            }
            else
            {
                int rnd = new Random().Next(1, 11);
                if (next != null)
                {
                    next.HandleRequest(rnd);
                }
            }
        }
    }
}
