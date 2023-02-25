using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0701_0800
{
    internal class _0796_RotateString
    {
        public bool RotateString(string s, string goal)
        {
            List<char> list = s.ToList();
            for (int i = 0; i < s.Length; i++)
            {
                string listString = string.Join("", list);
                if (listString == goal)
                {
                    return true;
                }
                else
                {
                    list.Add(list[0]);
                    list.Remove(list[0]);
                }
            }
            return false;
        }

        //Console.WriteLine(RotateString("abcde", "cdeab"));
    }
}
