using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0201_0300
{
    internal class _0231_PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n < 1)
            {
                return false;
            }

            double number = n;
            while (number >= 1 || number % 2 == 0)
            {
                if (number == 1)
                {
                    return true;
                }
                number /= 2;
            }
            return false;
        }

        //Console.WriteLine(IsPowerOfTwo(0));
        //Console.WriteLine(IsPowerOfTwo(1));
        //Console.WriteLine(IsPowerOfTwo(17));
        //Console.WriteLine(IsPowerOfTwo(2048));
    }
}
