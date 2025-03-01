using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class LongestSubstring
    {
        public void Start()
        {
            Console.Write("Enter your string ");
            string str=Console.ReadLine();

            int maxLength = 0;
            int n = str.Length;

            int left = 0;
            for (int right = left; right < n; right++)
            {
                for (int i = left; i < right; i++)
                {
                    if (str[i] == str[right])
                    {                   
                        left += 1;
                        break;
                    }                   
                }
                maxLength = right-left+1;
                
            }

            Console.WriteLine($"Length of longest subarray is {maxLength}");
            Console.WriteLine("\n");
        }
    }
}
