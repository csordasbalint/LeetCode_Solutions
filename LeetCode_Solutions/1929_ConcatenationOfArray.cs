using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1929_ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i];
            }

            return ans;
        }

        //int[] tmp = { 1, 2, 3, 4, 5, 6 };

        //var output = GetConcatenation(tmp);
        //foreach (var item in output)
        //{
        //    Console.Write(item + " ");
        //}

    }
}
