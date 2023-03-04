using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2101_2200
{
    internal class _2124_CheckIfAllA_sAppearsBeforeAllB_s
    {
        public bool CheckString(string s)
        {
            int idx = s.IndexOf("b");
            if (idx == -1)
            {
                return true;
            }
            string subString = s.Substring(idx, s.Length - idx);
            if (subString.Contains("a"))
            {
                return false;
            }
            return true;
        }

        //Console.WriteLine(CheckString("a"));
        //Console.WriteLine(CheckString("aaabbb"));
        //Console.WriteLine(CheckString("abbbba"));
    }
}
