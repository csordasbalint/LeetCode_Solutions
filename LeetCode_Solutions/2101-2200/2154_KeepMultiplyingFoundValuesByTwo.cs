using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2101_2200
{
    internal class _2154_KeepMultiplyingFoundValuesByTwo
    {
        public int FindFinalValue(int[] nums, int original)
        {
            while (nums.Contains(original))
            {
                original *= 2;
            }
            return original;
        }


        //int[] arr = { 5, 3, 6, 1, 12 };
        //int[] arr2 = { 2, 7, 9 }; 
        //Console.WriteLine(FindFinalValue(arr,3));
        //Console.WriteLine(FindFinalValue(arr2,4));
    }
}
