using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    class RotateArray180
    {
        internal static void Array180()
        {

            int[,] arr = { { 1, 2, 3, 4 },
                           { 5, 6, 7, 8 },
                           { 9, 10, 11, 12 },
                           { 13, 14, 15, 16 } };

            var rowLen = arr.GetLength(0);
            int endRow = rowLen - 1;
            for (int startRow = 0; startRow < endRow; startRow++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    //int temp = arr[startRow, col];
                    //arr[startRow, col] = arr[endRow, col];
                    //arr[endRow, col] = temp;

                    arr[startRow, col] = arr[startRow, col] + arr[endRow, col];
                    arr[endRow, col] = arr[startRow, col] - arr[endRow, col];
                    arr[startRow, col] = arr[startRow, col] - arr[endRow, col];
                }
                endRow--;
            }

            
            for (int startRow = 0; startRow < arr.GetLength(0); startRow++)
            {
                int endCol = arr.GetLength(1) - 1;
                for (int newCol = 0; newCol < endCol; newCol++)
                {
                    int a = arr[startRow, newCol];
                    arr[startRow, newCol] = arr[startRow, endCol];
                    arr[startRow, endCol] = a;

                    endCol--;
                }
                
            }

            Console.WriteLine("180 wise -");
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
