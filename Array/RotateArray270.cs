using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    public class RotateArray270
    {
        internal static void Rotate270Array()
        {
            int[,] arr = { { 1, 2, 3, 4 },
                           { 5, 6, 7, 8 },
                           { 9, 10, 11, 12 },
                           { 13, 14, 15, 16 } };

            int row = arr.GetLength(0);
            int col = arr.GetLength(1); 

            int[,] trr = new int[col, row];
            for (int tRow = 0; tRow < arr.GetLength(0); tRow++)
            {
                for (int tCol = 0; tCol < arr.GetLength(1); tCol++)
                {
                    trr[tCol, tRow] = arr[tRow, tCol];
                }
            }

            int endRow = trr.GetLength(0) - 1;

            for (int startRow = 0; startRow < endRow; startRow++)
            {
                for (int startCol = 0; startCol < trr.GetLength(1); startCol++)
                {
                    int temp = trr[startRow, startCol];
                    trr[startRow, startCol] = trr[endRow, startCol];
                    trr[endRow, startCol] = temp;
                }

                endRow--;
            }

            Console.WriteLine("270 degree wise :- ");
            for (int a = 0; a < trr.GetLength(0); a++)
            {
                for (int b = 0; b < trr.GetLength(1); b++)
                {
                    Console.Write(trr[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
