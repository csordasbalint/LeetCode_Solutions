using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _9_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            char[] x_to_charArray = x.ToString().ToCharArray();
            Array.Reverse(x_to_charArray);
            string output = new string(x_to_charArray);

            if (output.CompareTo(x.ToString()) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //var tmp = IsPalindrome(-121);
        //Console.WriteLine(tmp);
    }
}
