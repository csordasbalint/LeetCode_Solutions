using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2529_MaximumCountOfPositiveIntegerAndNegativeInteger
    {
        public int MaximumCount(int[] nums)
        {
            int negCount = 0;
            int posCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    negCount++;
                }
                if (nums[i] > 0)
                {
                    posCount++;
                }
            }
            return Math.Max(negCount, posCount);
        }

        //int[] arr = { -3, -2, -1, 0, 0, 1, 2 };
        //Console.WriteLine(MaximumCount(arr));
    }
}
