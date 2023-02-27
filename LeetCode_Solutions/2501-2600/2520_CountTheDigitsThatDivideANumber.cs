using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2520_CountTheDigitsThatDivideANumber
    {
        public int CountDigits(int num)
        {
            int count = 0;
            char[] arr = num.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (num % (arr[i] - 48) == 0)
                {
                    count++;
                }
            }

            return count;
        }

        //Console.WriteLine(CountDigits(7));
        //Console.WriteLine(CountDigits(121));
        //Console.WriteLine(CountDigits(1248));
    }
}
