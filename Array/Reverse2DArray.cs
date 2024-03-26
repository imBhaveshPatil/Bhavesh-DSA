using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    public class Reverse2DArray
    {
        internal static void ReverseArray2D()
        {
            int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            var length = arr.GetLength(0);
            
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

                    //Second
                    //arr[i, start] = arr[i, start] ^ arr[i, end];
                    //arr[i, end] = arr[i, start] ^ arr[i, end];
                    //arr[i, start] = arr[i, start] ^ arr[i, end];

                    // Third
                    //int a = arr[i, start];
                    //arr[i, start] = arr[i, end];
                    //arr[i, end] = a;

                    start++;
                    end--;
                    
                }
            }


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
