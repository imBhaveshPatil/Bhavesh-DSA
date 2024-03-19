using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    public class Sorting
    {
        public Sorting()
        {

        }
        internal static void SortArrays()
        {
            int[] array = {10, 5, -25, -7, 19, 2, -10};

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int temp = 0;
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                Console.WriteLine($"Value is = {array[i]}");
            }
        }
    }
}
