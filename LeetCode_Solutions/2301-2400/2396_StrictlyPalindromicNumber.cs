using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2301_2400
{
    internal class _2396_StrictlyPalindromicNumber
    {
        public bool IsStrictlyPalindromic(int n)
        {
            string binary;
            for (int i = 2; i <= n - 2; i++)
            {
                binary = Convert.ToString(n, i);
                if (binary != binary.Reverse())
                {
                    return false;
                }
            }
            return true;
        }

        //Console.WriteLine(IsStrictlyPalindromic(9));
        //Console.WriteLine(IsStrictlyPalindromic(4));
    }
}
