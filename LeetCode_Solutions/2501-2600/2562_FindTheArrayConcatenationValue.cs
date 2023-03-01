using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2562_FindTheArrayConcatenationValue
    {
        public long FindTheArrayConcVal(int[] nums)
        {
            long concatVal = 0;
            string numString = "";
            for (int i = 0; i < nums.Length / 2; i++)
            {
                numString = numString + (nums[i]);
                numString = numString + (nums[nums.Length - i - 1]);
                concatVal += Convert.ToInt64(numString);
                numString = "";
            }

            if (nums.Length % 2 != 0)
            {
                return concatVal + nums[nums.Length / 2];
            }
            return concatVal;
        }

        //int[] arr = { 7, 52, 2, 4 };
        //int[] arr = { 5, 14, 13, 8, 12 };
        //Console.WriteLine(FindTheArrayConcVal(arr));
    }
}
