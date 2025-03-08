using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class SelectionSort
    {

        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[index])         //updating index if smaller element is found
                    {
                        index = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }

        }
    }
}
