using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2586_CountTheNumbersOfVowelStringsInRange
    {
        public int VowelStrings(string[] words, int left, int right)
        {
            string vowels = "aeiou";
            int counter = 0;
            for (int i = left; i < right + 1; i++)
            {
                if (vowels.Contains(words[i][0]) && vowels.Contains(words[i][words[i].Length - 1]))
                {
                    counter++;
                }
            }

            return counter;
        }


        //string [] arr = { "n", "a", "o" };
        //string[] arr2 = { "are", "amy", "u" };
        //Console.WriteLine(VowelStrings(arr,0,2));
    }
}
