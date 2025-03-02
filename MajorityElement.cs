using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class MajorityElement
    {
        public void Start()
        {


            Console.WriteLine("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of array and press enter after each insertion");

            int[] copy = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                copy[i]=arr[i];
            }
            Console.WriteLine("\n");

            
            for(int i = 0; i < n-1; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if(copy[i] == copy[j])
                    {
                        copy[j] = -1;
                    }
                }
            }
            
            

            int nonDuplicate = 0;
            for(int i = 0; i < n; i++)
            {
                if (copy[i] != -1)
                {
                    nonDuplicate++;
                }
            }
            MoveZeroes mv = new MoveZeroes();
            mv.MoveZero(copy);

            int[] uniqueElements = new int[nonDuplicate];
            int[] frequency = new int[nonDuplicate];

           
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (copy[i] != -1)
                {
                    uniqueElements[index] = copy[i];
                    index++;
                }
            }

            
            for (int i = 0; i < nonDuplicate; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (uniqueElements[i] == arr[j])
                    {
                        count++;
                    }
                }
                frequency[i] = count;
            }

            
            int majorityElement = -1;
            int majorityThreshold = n / 2;

            for (int i = 0; i < nonDuplicate; i++)
            {
                if (frequency[i] > majorityThreshold)
                {
                    majorityElement = uniqueElements[i];
                    break;
                }
            }

            if (majorityElement != -1)
                Console.WriteLine($"The majority element is: {majorityElement}");
            else
                Console.WriteLine("No majority element found.");
        }
    


    }
}
