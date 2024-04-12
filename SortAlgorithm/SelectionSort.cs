using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.SortAlgorithm
{
    public class SelectionSort
    {
        internal static void SortingWithSelection()
        {
            int[] arr = { 64, 12, 8, 45, 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                if (i != minIndex)
                    (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);


                Console.WriteLine($"Selection Sort :- {arr[i]}");
            }
        }
    }
}
