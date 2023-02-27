using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1201_1300
{
    internal class _1281_SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        int SubtractProductAndSum(int n)
        {
            char[] arr = n.ToString().ToCharArray();
            int product = 1;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i] - 48;
                sum += arr[i] - 48;
            }
            return product - sum;
        }


        //Console.WriteLine(SubtractProductAndSum(234));
    }
}
