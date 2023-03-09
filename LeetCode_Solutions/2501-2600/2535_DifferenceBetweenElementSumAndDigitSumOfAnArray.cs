using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2535_DifferenceBetweenElementSumAndDigitSumOfAnArray
    {
        public int DifferenceOfSum(int[] nums)
        {
            string tmp;
            int digitSum = 0;
            int elementSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                elementSum += nums[i];
                if (nums[i] > 9)
                {
                    tmp = nums[i].ToString();
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        digitSum += Convert.ToInt32(tmp[j]) - 48;
                    }
                }
                else
                {
                    digitSum += nums[i];
                }
            }
            return Math.Abs(elementSum - digitSum);
        }


        //int[] tmp = { 1, 15, 6, 3 };
        //Console.WriteLine(DifferenceOfSum(tmp));
    }
}
