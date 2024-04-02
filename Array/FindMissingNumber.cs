using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    public class FindMissingNumber
    {
        internal static void FindMissingNumbers()
        {
            int[] arr = { 1, 2,3, 4, 6, 7, 8 };

            int n = arr.Length + 1;
            int sum = 0;
            int total = (n * (n + 1)) / 2;

            foreach (int num in arr)
            {
                sum += num;
            }
            
            Console.WriteLine($"Missing Numbers :- {total - sum}");
        }
    }
}
