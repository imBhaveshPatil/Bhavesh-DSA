using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    class ClockWise2DArray
    {
        internal static void RotateClockWise()
        {

            int[,] arr = { { 1, 2, 3, 4 },
                           { 5, 6, 7, 8 },
                           { 9, 10, 11, 12 },
                           { 13, 14, 15, 16 } };
            var length = arr.GetLength(0);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int temp;

                    if (i == j)
                        break;

                    temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }

            }

            for (int i = 0; i < length; i++)
            {
                int start = 0;
                int end = length - 1;

                while (start < end)
                {
                    // First
                    arr[i, start] = arr[i, start] + arr[i, end];
                    arr[i, end] = arr[i, start] - arr[i, end];
                    arr[i, start] = arr[i, start] - arr[i, end];

                    start++;
                    end--;

                }
            }
            Console.WriteLine("Clock wise -");
            for (int a = 0; a < arr.GetLength(0); a++)
            {
                for (int b = 0; b < arr.GetLength(1); b++)
                {
                    Console.Write(arr[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
