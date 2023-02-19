using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1512_NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int goodpairs = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i < j && nums[i] == nums[j])
                    {
                        goodpairs++;
                    }
                }
            }
            return goodpairs;
        }

        //int[] numbers = { 1, 2, 3, 1, 1, 3 };
        //Console.WriteLine(NumIdenticalPairs(numbers));
    }
}
