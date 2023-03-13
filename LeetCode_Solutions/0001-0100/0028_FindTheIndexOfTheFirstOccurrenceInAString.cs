using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0001_0100
{
    internal class _0028_FindTheIndexOfTheFirstOccurrenceInAString
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            return -1;
        }


        //Console.WriteLine(StrStr("sadbutsad", "sad"));
        //Console.WriteLine(StrStr("leetcode", "leeto"));
    }
}
