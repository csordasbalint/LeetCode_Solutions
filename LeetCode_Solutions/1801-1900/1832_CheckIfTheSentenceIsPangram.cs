using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1801_1900
{
    internal class _1832_CheckIfTheSentenceIsPangram
    {
        public bool CheckIfPangram(string sentence)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!sentence.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }

        //Console.WriteLine(CheckIfPangram("thequickbrownfoxjumpsoverthelazydog"));
    }
}
