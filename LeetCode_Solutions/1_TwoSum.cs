using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output = new int[] { i, j };
                        return output;
                    }
                }
            }
            return output;
        }

        //int [] tmp  = { 1, 2, 7, 9 };
        //int[] sol = TwoSum(tmp, 9);
        //foreach (var item in sol)
        //{
        //	Console.Write(item+" ");
        //}
    }
}
