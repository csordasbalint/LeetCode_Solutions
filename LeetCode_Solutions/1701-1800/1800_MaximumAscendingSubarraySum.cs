using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1701_1800
{
    internal class _1800_MaximumAscendingSubarraySum
    {
        public int MaxAscendingSum(int[] nums)
        {
            if (nums.Count() == 1)
            {
                return nums.Sum();
            }
            int tmp = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    tmp += nums[i];
                }
                else
                {
                    tmp += nums[i];
                    list.Add(tmp);
                    tmp = 0;
                }
            }

            if (nums[nums.Length - 2] <= nums[nums.Length - 1])
            {
                tmp += nums[nums.Length - 1];
                list.Add(tmp);
            }

            return list.Max();
        }


        //int[] arr = new int []{ 10, 20, 30, 5, 10, 50};
        //int[] arr2 = new int[] { 6 };
        //Console.WriteLine(MaxAscendingSum(arr2));
    }
}
