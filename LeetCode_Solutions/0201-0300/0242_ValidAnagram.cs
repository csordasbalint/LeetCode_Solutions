using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0201_0300
{
    internal class _0242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
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
                    return false;
                }
            }

            if (list2.Count == 0)
            {
                return true;
            }
            return false;
        }

        //Console.WriteLine(IsAnagram("alma", "mala"));
    }
}
