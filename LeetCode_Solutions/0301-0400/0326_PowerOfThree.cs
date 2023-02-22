using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0301_0400
{
    internal class _0326_PowerOfThree
    {
        public bool IsPowerOfThree(int n)
        {
            if (n < 1)
            {
                return false;
            }

            double number = n;
            while (number >= 1 || number % 3 == 0)
            {
                if (number == 1)
                {
                    return true;
                }
                number /= 3;
            }
            return false;
        }

        //Console.WriteLine(IsPowerOfThree(0));
        //Console.WriteLine(IsPowerOfThree(1));
        //Console.WriteLine(IsPowerOfThree(12));
        //Console.WriteLine(IsPowerOfThree(27));
    }
}
