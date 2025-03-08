using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class BinarySearch
    {
        public static void Search(int[] arr, int key)
        {
            int n = arr.Length;
            int low = arr[0];
            int high = arr[n - 1];

            while (low <= high)
            {
                int mid=low + ((high-low)/2);

                if (arr[mid] == key)
                {
                    Console.WriteLine($"index of {key} in the array is {mid}");
                    return;
                }
                else if (arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }
    }
}
