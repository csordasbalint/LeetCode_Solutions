using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2600_KItemsWithTheMaximumSum
    {
        public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k)
        {
            int output = 0;
            int[] arr = new int[numOnes + numZeros + numNegOnes];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < numOnes && i < k)
                {
                    arr[i] = 1;
                    output += arr[i];
                }
                else if (i < numOnes + numZeros && i < k)
                {
                }
                else if (i < k)
                {
                    arr[i] = -1;
                    output += arr[i];
                }
            }
            return output;
        }

        //Console.WriteLine(KItemsWithMaximumSum(3, 2, 0, 2));
        //Console.WriteLine(KItemsWithMaximumSum(2, 5, 0, 3));
        //Console.WriteLine(KItemsWithMaximumSum(1, 1, 3, 5));
        //Console.WriteLine(KItemsWithMaximumSum(6, 6, 6, 13));
        //Console.WriteLine(KItemsWithMaximumSum(1, 3, 3, 5));
        //Console.WriteLine(KItemsWithMaximumSum(1, 1, 1, 3));
    }
}
