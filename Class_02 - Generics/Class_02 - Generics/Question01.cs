using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02___Generics
{

    //public class Qst01
    //{
    //    //public int count = 0;

    //    //public T[] Add<T,U>(T[] array1, T[] array2)
    //    //{
    //    //    T[] array3 = new T[array1.Length + array2.Length];

    //    //    foreach (T arrayT in array1)
    //    //    {
    //    //        array3[count++] = arrayT;
    //    //    }

    //    //    foreach (T arrayU in array2)
    //    //    {
    //    //        array3[count++] = arrayU;
    //    //    }

    //    //    return array3;
    //    //}
    //}

    public class Try<T>
    {
        public int count = 0;

        public T[] Add(T[] array1, T[] array2)
        {
            T[] array3 = new T[array1.Length + array2.Length];

            foreach (T arrayT in array1)
            {
                array3[count++] = arrayT;
            }

            foreach (T arrayU in array2)
            {
                array3[count++] = arrayU;
            }

            return array3;
        }
    }

   

   
}
