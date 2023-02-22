using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0301_0400
{
    internal class _0342_PowerOfFour
    {
        public bool IsPowerOfFour(int n)
        {
            if (n < 1)
            {
                return false;
            }

            double number = n;
            while (number >= 1 || number % 4 == 0)
            {
                if (number == 1)
                {
                    return true;
                }
                number /= 4;
            }
            return false;
        }

        //Console.WriteLine(IsPowerOfFour(0));
        //Console.WriteLine(IsPowerOfFour(1));
        //Console.WriteLine(IsPowerOfFour(9));
        //Console.WriteLine(IsPowerOfFour(16));
    }
}
