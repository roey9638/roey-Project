using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methood
{
    class BuisnessFactory
    {
        //Here I'm just creating new [Instance] of the [Buisness1] [Class].
        public static Buisness1 Creat()
        {
            return new Buisness1();
        }
    }
}
