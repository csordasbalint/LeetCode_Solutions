using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0101_0200
{
    internal class _0169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            var output = from x in nums
                         group x by x into g
                         select new
                         {
                             tmp = g.Key,
                             mostFreq = g.Count()
                         };

            foreach (var item in output)
            {
                if (item.mostFreq > nums.Length / 2)
                {
                    return item.tmp;
                }
            }
            return 0;
        }

        //int[] test = { 2, 2, 1, 1, 1, 2, 2 };
        //Console.WriteLine(MajorityElement(test));
    }
}
