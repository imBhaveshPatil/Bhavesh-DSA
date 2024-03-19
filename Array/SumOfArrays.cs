using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    class SumOfArrays
    {
        internal static void SumOfArray()
        {
            int[] array = { 10, 5, -25, -7, 19, 2, -10 };

            int max = array[0];

            for (int a = 1; a < array.Length; a++)
            {
                max += array[a];
            }

            Console.WriteLine(" Array Of Sum " + max);
        }
    }
}
