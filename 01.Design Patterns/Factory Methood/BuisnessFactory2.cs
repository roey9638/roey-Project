using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methood
{
    class BuisnessFactory2
    {
        public static Buisness2 Creat()
        {
            return new Buisness2("Gal", 22);
        }
    }
}
