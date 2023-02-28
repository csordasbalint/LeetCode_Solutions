using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0201_0300
{
    internal class _0217_ContainsDuplicates
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Distinct().Count() == nums.Count())
            {
                return false;
            }

            return true;
        }

        //int[] arr = { 1, 2, 3, 1 };
        //Console.WriteLine(ContainsDuplicate(arr));
    }
}
