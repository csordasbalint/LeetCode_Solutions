using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2401_2500
{
    internal class _2475_NumberOfUnequalTripletsInArray
    {
        public int UnequalTriplets(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] != nums[j] && nums[i] != nums[k] && nums[j] != nums[k])
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }


        //int[] arr = { 4, 4, 2, 4, 3 };
        //Console.WriteLine(UnequalTriplets(arr));
    }
}
