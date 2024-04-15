using System;

namespace Bhavesh_DSA.SortAlgorithm
{
    public class BubbleSort
    {
        internal static void SortingWithBubble()
        {
            int[] arr = { 2, 8, 4, -1, 7, 10, 5, 6 };

            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                }

                Console.WriteLine($"Bubble Sort :- {arr[i]}");
            }
        }
    }
}
