using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1801_1900
{
    internal class _1805_NumberOfDifferentIntegersInAString
    {
        public int NumDifferentIntegers(string word)
        {
            string tmp = "";
            char[] arr = word.ToCharArray();
            List<BigInteger> list = new List<BigInteger>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!char.IsDigit(arr[i]))
                {
                    arr[i] = ' ';
                }
                else
                {
                    while (i < arr.Length && char.IsDigit(arr[i]))
                    {
                        tmp += arr[i];
                        i++;
                    }
                    list.Add(BigInteger.Parse(tmp));
                    tmp = "";
                    i--;
                }
            }
            return list.Distinct().Count();
        }

        //Console.WriteLine(NumDifferentIntegers("a123bc34d8ef34"));
    }
}
