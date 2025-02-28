using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
     class CheckPalindrome
    {
        public void start()
        {
            bool flag = true;   
            Console.WriteLine("Enter the string that you want to check");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    flag = false;
                    break;
                }
                               
            }
            if (flag)
            {
                Console.WriteLine($"{str} is palindrome");
            }
            else
            {
                Console.WriteLine($"{str} is not palindrome");
            }
            Console.WriteLine("\n");
        }
    }
}
