using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1969_NumberOfStringsThatAppearAsSubstringsInWord
    {
        public int NumOfStrings(string[] patterns, string word)
        {
            int count = 0;
            for (int i = 0; i < patterns.Length; i++)
            {
                if (word.Contains(patterns[i]))
                {
                    count++;
                }
            }

            return count;
        }

        //string[] listOfPatterns = { "a", "b", "c", "bc", "daf", "ye", "abc", "abcc" };

        //int tmp = NumOfStrings(listOfPatterns, "abc");
        //Console.WriteLine(tmp);

    }
}
