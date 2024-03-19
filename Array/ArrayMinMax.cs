using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bhavesh_DSA.Array
{
    public class ArrayMinMax
    {
        internal static void MinMaxArray()
        {
            int[] array = { 10, 5, -25, -7, 19, 2, -10 };
            
            int max = array[0];
            int min = array[0];

            for (int a = 1; a < array.Length; a++)
            {

                if (max < array[a]) // min > array[a]
                {
                    max = array[a];
                }
                if(min > array[a])
                {
                    min = array[a];
                }

            }
            int sum = max + min;
            Console.WriteLine(" Number Max ----- " + max);
            Console.WriteLine(" Number Min ----- " + min);
            Console.WriteLine(" sum ofN ----- " + sum);
        }
    }
}
