using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2114_MaximumNumberOfWordsFoundInSentences
    {
        int MostWordsFound(string[] sentences)
        {
            int output = 0;
            int max = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                char[] string_to_charArray = sentences[i].ToCharArray();
                output = string_to_charArray.Count(char.IsWhiteSpace);
                if (output > max)
                {
                    max = output;
                }
            }
            return max + 1;
        }

        //string[] sentences = {"Alma, beka, kecske" , "This aint working" , "Or is it? i dunno"};
        //int tmp = MostWordsFound(sentences);
        //Console.WriteLine(tmp);
    }
}
