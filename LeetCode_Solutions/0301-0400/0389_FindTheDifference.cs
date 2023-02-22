using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0301_0400
{
    internal class _0389_FindTheDifference
    {
        public char FindTheDifference(string s, string t)
        {
            List<char> list1 = s.ToList();
            List<char> list2 = t.ToList();

            foreach (var element in list1)
            {
                if (list2.Contains(element))
                {
                    list2.Remove(element);
                }
                else
                {
                    return element;
                }
            }

            if (list2.Count == 1)
            {
                return list2.ElementAt(0);
            }
            return 'x';
        }

        //Console.WriteLine(FindTheDifference("miss","missu"));
    }
}
