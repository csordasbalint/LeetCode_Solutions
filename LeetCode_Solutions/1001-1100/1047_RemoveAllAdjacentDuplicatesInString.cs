using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1001_1100
{
    internal class _1047_RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string s)
        {
            List<char> list = s.ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                    i = -1;
                }
            }

            string output = string.Join("", list);
            return output;
        }


        //Console.WriteLine(RemoveDuplicates("abbaca"));
    }
}
