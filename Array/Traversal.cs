using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    class Traversal
    {
        internal static void ArrayTraversal()
        {
            int[,] tr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },{ 9,10,11,12}, { 13,14,15,16} };

            for (int i = 0; i < tr.GetLength(0); i++)
            {
                for (int j = 0; j < tr.GetLength(1); j++)
                {
                    int temp;

                    if (i == j)
                        break;

                    temp = tr[i, j];
                    tr[i, j] = tr[j, i];
                    tr[j, i] = temp;
                }

            }
            //for (int i = 0; i < tr.GetLength(0); i++)
            //{
            //    for (int j = i + 1; j < tr.GetLength(1); j++) // Start inner loop from i+1 (to avoid duplicates)
            //    {
            //        if (i != j) // Check if not on the diagonal
            //        {
            //            int temp = tr[i, j];
            //            tr[i, j] = tr[j, i];
            //            tr[j, i] = temp;
            //        }
            //    }
            //}

            Console.WriteLine("traversal");
            for (int a = 0; a < tr.GetLength(0); a++)
            {
                for (int b = 0; b < tr.GetLength(1); b++)
                {
                    Console.Write(tr[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
