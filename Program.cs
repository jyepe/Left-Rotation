using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int k = 4;
            int n = 5;

            int[] temp = new int[k];
            int count = 0;

            for (int i = 0; i < k; i++)
            {
                temp[i] = a[i];
            }

            for (int i = k; i < n; i++)
            {
                a[i - k] = a[i];
            }

            for (int i = n - k; i < n; i++)
            {
                a[i] = temp[count];
                count++;
            }

            printArray(a);
        }

        private static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Debug.Write(array[i] + " ");
            }
        }
    }
}
