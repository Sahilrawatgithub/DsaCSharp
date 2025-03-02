using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class MaximumSubarray
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

            int MaxSum=int.MinValue;
            for (int start = 0; start < n; start++)
            {
                int currSum = 0;
                for (int end = start; end < n; end++)
                {
                  currSum += arr[end];
                   
                    if (currSum > MaxSum)
                    {
                        MaxSum = currSum;
                    }
                    if (currSum < 0)      
                    {
                        currSum = 0;
                    }
                }               
            }
            Console.WriteLine($"The maximum sum is {MaxSum}.");
            
        }
    }
}
