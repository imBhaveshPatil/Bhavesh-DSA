using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    public class NutsBolts
    {
        public static void nutBoltMatch()
        {
            char[] nuts = { '@', '#', '$', '%', '^', '&' };
            char[] bolts = { '$', '%', '&', '^', '@', '#' };
            int n = nuts.Length;

            Dictionary<char, int> hash = new Dictionary<char, int>();
            for (int i = 0; i < n; i++)
            {
                hash[nuts[i]] = i;
            }
            for (int i = 0; i < n; i++)
            {
                if (hash.ContainsKey(bolts[i]))
                {
                    nuts[i] = bolts[i];
                }
            }
            Console.WriteLine("Matched nuts and bolts are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nuts[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(bolts[i] + " ");
            }
        }
    }
}
