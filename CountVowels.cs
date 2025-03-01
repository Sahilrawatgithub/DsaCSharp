using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class CountVowels
    {
        public void Start()
        {
            Console.Write("Enter your string :");
            string str=Console.ReadLine();

            string vowel = "aeiouAEIOU";
            int vowels = 0;
            int consonants = 0;


            for(int i =0; i < str.Length; i++)
            {
                bool isVowel = false;
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (str[i] == vowel[j])
                    {
                        vowels += 1;
                        isVowel = true;
                        break;
                    }                     
                }
                if (!isVowel)
                {
                    consonants += 1;
                }
            }

            Console.WriteLine($"Count of vowels: {vowels}");
            Console.WriteLine($"Count of consonants: {consonants}");
            Console.WriteLine("\n");

        }
    }
}
