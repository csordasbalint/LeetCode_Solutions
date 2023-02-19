using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2413_SmallestEvenMultiple
    {
        int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0)
            {
                return n;
            }
            else
            {
                return 2 * n;
            }
        }

        //int output = SmallestEvenMultiple(15);
        //Console.WriteLine(output);
    }
}
