using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0901_1000
{
    internal class _0905_SortArrayByParity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even.Add(nums[i]);
                }
                else
                {
                    odd.Add(nums[i]);
                }
            }
            even.AddRange(odd);
            return even.ToArray();
        }

        //int []numbers = { 3, 1, 2, 4 };
        //int[] arr = SortArrayByParity(numbers);
        //foreach (var item in arr)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
