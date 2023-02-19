using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2108_FindFirstPalindromicStringInTheArray
    {
        public string FirstPalindrome(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                char[] word_to_charArray = words[i].ToCharArray();
                Array.Reverse(word_to_charArray);
                string output = new string(word_to_charArray);

                if (output.CompareTo(words[i]) == 0)
                {
                    return words[i];
                }
            }

            return "";
        }

        //string[] listOfWords = { "asd", "sad", "asw", "ada", "add", "tacocat", "racecar" };
        //string tmp = FirstPalindrome(listOfWords);
        //Console.WriteLine(tmp);
    }
}
