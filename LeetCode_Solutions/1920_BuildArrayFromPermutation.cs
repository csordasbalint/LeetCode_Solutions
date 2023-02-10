using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1920_BuildArrayFromPermutation
    {
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }

            return ans;
        }

        //int[] tmp = { 0, 2, 1, 5, 3, 4 };
        //int[] output = BuildArray(tmp);
        //foreach (var item in output)
        //{
        //	Console.WriteLine(item);
        //}
    }
}
