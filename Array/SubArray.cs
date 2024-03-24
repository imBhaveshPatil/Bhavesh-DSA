using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    public class SubArray
    {
        internal static void FindSubArrayAndCount()
        {
            int[] array = { 1, 2, 3, 4 };
            string subArray = string.Empty;

            int n = array.Length;

            // Loop through all possible subarray lengths
            for (int len = 1; len <= n; len++)
            {
                // Loop through all possible starting indices
                for (int start = 0; start <= n - len; start++)
                {
                    // Print subarray from start index to start + len - 1
                    for (int i = start; i < start + len; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    Console.WriteLine();
                }
            }

            //return;
            
            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                if (!string.IsNullOrWhiteSpace(subArray))
                    subArray += "-";

                subArray += array[cnt].ToString();

            }
            subArray = "{" + subArray.Replace("-", "},{") + "}";

            string emArr = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    emArr += "{" + array[i] + "," + array[j] + "}";

                    if (j < array.Length)
                    {
                        emArr += ",";
                        break;
                    }
                        
                }
            }

            string subArr3 = string.Empty;
            for (int a = 0; array[a] < array.Length; a++)
            {
                if (!string.IsNullOrWhiteSpace(subArr3))
                    subArr3 += ",";

                subArr3 += array[a].ToString();
            }
            subArr3 = "{" + subArr3 + "}";

            string end = subArr3.Substring(subArr3.Length - 1);

            for (int b = 1; b < array.Length; b++)
            {
                
                if (!string.IsNullOrWhiteSpace(subArr3))
                    subArr3 += subArr3.EndsWith(end) ? ",{" : ",";

                subArr3 += array[b].ToString();
            }
            subArr3 += "}";


            Console.WriteLine(subArray + emArr + subArr3 + "\r\r\n\n");
        }
    }
}
