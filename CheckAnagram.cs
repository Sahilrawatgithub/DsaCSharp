using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class CheckAnagram
    {
        public void start()
        {
            Console.WriteLine("Enter string 1: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter string 2:");
            string rts = Console.ReadLine();

            if (str.Length != rts.Length)
            {
                Console.WriteLine("not anagram");
            }
            else
            {

                char[] arr1 = str.ToCharArray();
                char[] arr2 = rts.ToCharArray();

                Array.Sort(arr1);
                Array.Sort(arr2);

                bool check = (new string(arr1) == new string(arr2));

                if (check)
                {
                    Console.WriteLine("are anagram");
                }
                else
                {
                    Console.WriteLine("are not anagram");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
