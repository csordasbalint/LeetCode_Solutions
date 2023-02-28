using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1801_1900
{
    internal class _1816_TruncateSentence
    {
        public string TruncateSentence(string s, int k)
        {
            List<string> list = s.Split(" ").ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (i >= k)
                {
                    list.RemoveRange(i, list.Count - i);
                    break;
                }
            }

            string output = string.Join(" ", list);
            return output;
        }

        //Console.WriteLine(TruncateSentence("What is the solution to this problem", 4));
    }
}
