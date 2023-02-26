using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0901_1000
{
    internal class _0977_SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);
            return nums;
        }

        //int[] numbers = { -7, -3, 2, 3, 11 };
        //int[] arr = SortedSquares(numbers);
        //foreach (var item in arr)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
