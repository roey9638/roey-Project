using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    abstract class CarWorkShop
    {
        protected CarWorkShop next;

        public void SetNext(CarWorkShop newNext)
        {
            next = newNext;
        }

        public abstract void HandleRequest(int check);
    }
}
