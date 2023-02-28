using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1301_1400
{
    internal class _1365_HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] output = new int[nums.Length];
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i] && j != i)
                    {
                        counter++;
                    }
                }
                output[i] = counter;
                counter = 0;
            }

            return output;
        }

        //int[] arr = { 8, 1, 2, 2, 3};
        //int[] arr = { 6, 5, 4, 8 };
        //int[] tmp = SmallerNumbersThanCurrent(arr);
        //foreach (var item in tmp)
        //{
        //	Console.WriteLine(item);
        //}
    }
}
