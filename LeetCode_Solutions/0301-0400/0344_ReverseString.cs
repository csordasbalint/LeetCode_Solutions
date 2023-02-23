using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0301_0400
{
    internal class _0344_ReverseString
    {
        public void ReverseString(char[] s)  //char []
        {
            char extraChar;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length - 1 - i < i)
                {
                    break;
                }
                extraChar = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = s[i];
                s[i] = extraChar;
            }
            //return s
        }

        //char[] arr = {'A','b','c','d' ,'e', 'a' };
        //ReverseString(arr);
        //foreach (var item in arr)
        //{
        //	Console.WriteLine(item);
        //}
    }
}
