using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2553_SeperateTheDigitsInAnArray
    {
        public int[] SeparateDigits(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                sb.Append(nums[i]);
            }
            int[] output = sb.ToString().Select(x => x - 48).ToArray();

            return output;
        }


        //int[] numbers = { 13, 25, 83, 77 };
        //int[] tmp = SeparateDigits(numbers);
        //foreach (var item in tmp)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
