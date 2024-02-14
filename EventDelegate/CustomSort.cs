using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    internal class CustomSort
    {
        public delegate bool DelegateComparer<T>(T x, T y);

        public static void Sort<T>(T[] values, DelegateComparer<T> comparer)
        {
            int n = values.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparer(values[j], values[j + 1]))
                    {
                        T temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
        }
    }
}
