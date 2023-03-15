using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0001_0100
{
    internal class _0058_LengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            List<string> list = s.Split(" ").ToList();
            return list.Last().Length;
        }


        //Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
        //Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
    }
}
