using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1601_1700
{
    internal class _1662_CheckIfTwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string w1 = "";
            string w2 = "";

            for (int i = 0; i < word1.Length; i++)
            {
                w1 += word1[i];

            }
            for (int i = 0; i < word2.Length; i++)
            {
                w2 += word2[i];
            }

            if (w1.CompareTo(w2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //string[] set1 = {"a","bcc" };
        //string[] set2 = { "ab", "c" };
        //Console.WriteLine(ArrayStringsAreEqual(set1,set2));
    }
}
