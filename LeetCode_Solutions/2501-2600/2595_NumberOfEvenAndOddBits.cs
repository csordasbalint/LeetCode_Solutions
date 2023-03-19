using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2595_NumberOfEvenAndOddBits
    {
        public int[] EvenOddBit(int n)
        {
            int oddCounter = 0;
            int evenCounter = 0;
            char[] arr = Convert.ToString(n, 2).ToCharArray();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0 && arr[i] == '1')
                {
                    evenCounter++;
                }
                else if (i % 2 == 1 && arr[i] == '1')
                {
                    oddCounter++;
                }
            }

            return new int[] { evenCounter, oddCounter };
        }

        //int[] tmp = EvenOddBit(2);
        //int[] tmp2 = EvenOddBit(17);
        //foreach (var item in tmp)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
