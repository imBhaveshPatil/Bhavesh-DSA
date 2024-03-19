using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhavesh_DSA.Array
{
    class StringOperator
    {
        internal static void OperatorStringArray()
        {
            string[] str = { "x++", "x--", "--x", "++x"};
            int x = 0;

            for (int i = 0; i < str.Length; i++)
            {
                x = str[i].Contains("+") ? x++ : x--;
            }
            Console.WriteLine($"Value of X is :- {x}");
        }
    }
}
