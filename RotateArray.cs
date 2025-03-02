using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class RotateArray
    {
        public void Start()
        {
            Console.WriteLine("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of array and press enter after each insertion");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            Console.WriteLine("Enter k");
            int k=Convert.ToInt32(Console.ReadLine());


            Array.Reverse(arr, 0, n - k);
            Array.Reverse (arr, n - k,k);
            Array.Reverse(arr);

            Console.WriteLine("The shifted array is :");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");

        }
    }
}
