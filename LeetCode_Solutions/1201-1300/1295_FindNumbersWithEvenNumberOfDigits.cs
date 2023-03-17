using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1201_1300
{
    internal class _1295_FindNumbersWithEvenNumberOfDigits
    {
        public int FindNumbers(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].ToString().Length % 2 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }


        //int[] arr = { 12, 345, 2, 6, 7896 };
        //Console.WriteLine(FindNumbers(arr));
    }
}
