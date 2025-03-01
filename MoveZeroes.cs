using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class MoveZeroes
    {
        public void Start()
        {
           
            Console.WriteLine("Enter the size of array : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of array and press enter after each insertion");
            for(int i = 0; i < n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            Console.WriteLine("Here is the array before adjusting zeroes");
           
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[i] == 0 && arr[j]!=0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        break;
                    }
                    
                }
            }
            
            Console.WriteLine("Here is array after putting zeroes at end");
            
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");
        }
    }
}
