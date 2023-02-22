using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0201_0300
{
    internal class _0255_AddDigits
    {
        public int AddDigits(int num)
        {
            int output = 0;
            if (num < 10)
            {
                return num;
            }

            bool jout = true;
            while (jout)
            {
                output = 0;
                char[] arr = num.ToString().ToCharArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    output += arr[i] - 48;
                }
                if (output < 10)
                {
                    jout = false;
                }
                num = output;
            }
            return output;
        }

        //Console.WriteLine(AddDigits(0));
        //Console.WriteLine(AddDigits(38));
        //Console.WriteLine(AddDigits(55));
    }
}
