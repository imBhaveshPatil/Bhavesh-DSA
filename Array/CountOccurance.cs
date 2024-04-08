using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    public class CountOccurance
    {
        internal static void NumOfOccurances()
        {
            int[] arr = { 1, 2, 3, 4, 5, 7, 8, 5, 9, 5, 3, 7, 7 };
            int cnt = 0;
            int target = 3;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    cnt += 1;
            }
            Console.Write("Num of Occurances");
            Console.WriteLine($"Count is :- {cnt}");
        }
    }
}
