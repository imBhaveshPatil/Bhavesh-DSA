using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    class MatrixTranspose
    {
        /*  input
            1   2   3   4  
            5   6   7   8  
            9   10  11  12 
            13  14  15  16
            17  18  19  20

            output
            1   5    9  13  17
            2   6  10  14  18
            3   7  11  15  19
            4   8  12  16  20  */


        internal static void TransposeMatrix()
        {
            int[,] arr = { { 1, 2, 3, 4 }, 
                           { 5, 6, 7, 8 }, 
                           { 9, 10, 11, 12 }, 
                           { 13, 14, 15, 16 },
                            { 17,18,19,20} };


            int row = arr.GetLength(0); // 5
            int col = arr.GetLength(1); // 4

            int[,] trr = new int[col,row];



            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    trr[j, i] = arr[i, j];
                }
            }
            Console.WriteLine("Transposed mat");
            for (int a = 0; a < col; a++)
            {
                for (int b = 0; b < row; ++b)
                {
                    Console.Write(trr[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
