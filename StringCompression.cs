using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class StringCompression
    {
        public void Start()                   
        {
            Console.Write("Enter string you want to compress :");
            string str=Console.ReadLine();

            for(int i = 0; i < str.Length; i++)
            {
                int count = 1;
                for(int j=i+1;j<str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count += 1;                       
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Write($"{str[i]}{count}");
                i += count - 1;
            }
            Console.WriteLine("\n");

        }
    }
}
