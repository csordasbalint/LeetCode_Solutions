using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1601_1700
{
    internal class _1689_PartitioningIntoMinimumNumberOfDeci_BinaryNumbers
    {
        public int MinPartitions(string n)
        {
            char[] arr = n.ToCharArray();
            return arr.Max() - 48;
        }
    }
}
