using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2160_MinimumSumOfFourDigitNumberAfterSplittingDigits
    {
        int MinimumSum(int num)
        {
            char[] array = num.ToString().ToCharArray();
            Array.Sort(array);
            int ascii = 48;

            int[] num1Array = new int[2];
            num1Array[0] = array[0] - ascii;
            num1Array[1] = array[2] - ascii;

            int[] num2Array = new int[2];
            num2Array[0] = array[1] - ascii;
            num2Array[1] = array[3] - ascii;

            int output1 = num1Array.Select((x, i) => x * Convert.ToInt32(Math.Pow(10, array.Length - i - 1))).Sum() / 100;
            int output2 = num2Array.Select((y, j) => y * Convert.ToInt32(Math.Pow(10, array.Length - j - 1))).Sum() / 100;

            return output1 + output2;
        }

        //int tmp = MinimumSum(2022);
        //Console.WriteLine(tmp);
    }
}
