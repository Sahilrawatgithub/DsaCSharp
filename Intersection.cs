using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class Intersection
    {
        public void Start()
        {
            Console.WriteLine("Enter the size of array1 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Enter the elements of array1 and press enter after each insertion");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            Console.WriteLine("Enter the size of array2 : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[m];
            Console.WriteLine("Enter the elements of array2 and press enter after each insertion");
            for (int i = 0; i < m; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        arr2[j] = -1;
                        Console.WriteLine(arr1[i]+ " ");
                        break;
                    }
                }
            }
        }
    }
}
