using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    public class RemoveDuplicateElements
    {
        internal static void ToRemoveDuplicateElements()
        {
            int[] arr = { 1, 3, 2, 4, 8, 2, 4, 6, 5, 6 };

            /* 
             *  With Linq Distinct
            int[] newArray = arr.Distinct().ToArray();

            foreach (int item in newArray)
            {
                Console.WriteLine(item);
            }


            return;
            */

            int currentIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    arr[currentIndex] = arr[i];
                    currentIndex++;
                }
            }

            // New array with the actual number of unique elements
            int[] uniqueArray = new int[currentIndex];
            System.Array.Copy(arr,uniqueArray, currentIndex);

            foreach (int item in uniqueArray)
            {
                Console.WriteLine($"New Array :- {item}");
            }
            

        }

    }
}
