using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02___Generics
{
    public class ReadOnly<T>
    {
        #region Qst 02

        T[] generic = new T[10];

        public bool IsReadOnly { get; set; } = false;

        private int count = 1;

        public void Add(T data)
        {          
            if (!IsReadOnly)
            {
                for (int i = 0; i < generic.Length; i++)
                {
                    if (generic[i] == null)
                    {
                        generic[i] = data;
                                          
                    }

                }
            }
            else
            {
                throw new InvalidOperationException("IsReadOnly is true");

            }
        }

        #endregion

        #region Qst 01

        public T[] Combine(T[] array1 , T[] array2)
        {
            T[] array3 = new T[array1.Length + array2.Length];

            int count = 0;

            foreach (T array in array1)
            {
                array3[count++] = array;
            }

            foreach (T array in array2)
            {
                array3[count++] = array;
            }

            return array3;
        }

        #endregion

        
    }
}
