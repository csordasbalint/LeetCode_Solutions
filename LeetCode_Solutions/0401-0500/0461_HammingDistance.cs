using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0401_0500
{
    internal class _0461_HammingDistance
    {
        public int HammingDistance(int x, int y)
        {
            char[] bin1 = Convert.ToString(x, 2).PadLeft(32, '0').ToCharArray();
            char[] bin2 = Convert.ToString(y, 2).PadLeft(32, '0').ToCharArray();

            int counter = 0;

            for (int i = 0; i < bin2.Length; i++)
            {
                if (bin1[i] != bin2[i])
                {
                    counter++;
                }
            }

            return counter;
        }

        //Console.WriteLine(HammingDistance(1,4));
    }
}
