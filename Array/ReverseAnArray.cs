using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    class ReverseAnArray
    {
        internal static void ReverseArray()
        {
            int[] arr =  {10, 5, -25, -7, 19, 2, -10, 23, 44};
            int temp;
            int last = arr.Length - 1;

            for (int i = 0; i < arr.Length/2; i++)
            {
                temp = arr[i];
                arr[i] = arr[last];
                arr[last] = temp;
                 last--;
            }
            for (int ind = 0; ind < arr.Length; ind++)
            {
                Console.WriteLine($"Reverse array :- {arr[ind]}");
            }

        }
    }
}
