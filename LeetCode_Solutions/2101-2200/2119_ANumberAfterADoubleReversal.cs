using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2101_2200
{
    internal class _2119_ANumberAfterADoubleReversal
    {
        public bool IsSameAfterReversals(int num)
        {
            char[] arr = num.ToString().ToArray();
            Array.Reverse(arr);
            int tmp = int.Parse(arr);

            char[] arr2 = tmp.ToString().ToCharArray();
            Array.Reverse(arr2);
            int tmp2 = int.Parse(arr2);
            if (tmp2 == num)
            {
                return true;
            }

            return false;
        }


        //Console.WriteLine(IsSameAfterReversals(0));
        //Console.WriteLine(IsSameAfterReversals(526));
        //Console.WriteLine(IsSameAfterReversals(1800));
    }
}
