using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1480_RunningSumOf1DArray
    {
        public int[] RunningSum(int[] nums)
        {
            int[] runningsum = new int[nums.Length];
            int elementValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                runningsum[i] = elementValue += nums[i];
            }
            return runningsum;
        }

        //int[] numbers = { 1, 2, 3, 4 };
        //foreach (var item in RunningSum(numbers))
        //{
        //    Console.WriteLine(item);
        //}
    }
}
