using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2185_CountingWordsWithAGivenPrefix
    {
        public int PrefixCount(string[] words, string pref)
        {
            int countOfWords = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(pref))
                {
                    countOfWords++;
                }
            }

            return countOfWords;
        }

        //string[] listOfWords = { "Vater", "Mutter", "Bruder", "Schwester", "Großmutter", "GroßVater", "Multi" };
        //string prefix = "Mu";
        //var tmp = PrefixCount(listOfWords, prefix);
        //Console.WriteLine(tmp);
    }
}
