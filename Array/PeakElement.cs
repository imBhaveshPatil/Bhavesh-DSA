using System;

namespace Bhavesh_DSA.Array
{
    public class PeakElement
    {
        internal static void FindPeakElementFromArray()
        {
            int[] arr = { 2, 8, 4, -1, 7, 10, 5, 6 };
            int n = arr.Length;
            int point = GetPeakElement(arr, n);

            Console.WriteLine($"Peak Point is :- {point}");

        }
        private static int GetPeakElement(int[] arr, int n)
        {
            if (n == 1)
                return 0;
            if (arr[0] >= arr[1])
                return 0;
            if (arr[n - 1] >= arr[n - 2])
                return n - 1;

            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] >= arr[i - 1] && arr[i] >= arr[i + 1])
                    return i;
            }

            return 0;
        }
    }
}
