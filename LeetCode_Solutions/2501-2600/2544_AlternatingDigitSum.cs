using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2544_AlternatingDigitSum
    {
        public int AlternateDigitSum(int n)
        {
            int output = 0;
            char[] arr = n.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    output += (arr[i] - 48);
                }
                else
                {
                    output -= (arr[i] - 48);
                }
            }
            return output;
        }


        //Console.WriteLine(AlternateDigitSum(521));
        //Console.WriteLine(AlternateDigitSum(111));
        //Console.WriteLine(AlternateDigitSum(886996));
    }
}
