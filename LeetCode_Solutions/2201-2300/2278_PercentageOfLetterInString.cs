using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2201_2300
{
    internal class _2278_PercentageOfLetterInString
    {
        public int PercentageLetter(string s, char letter)
        {
            return s.Count(x => x == letter) * 100 / (s.Length);
        }


        //Console.WriteLine(PercentageLetter("foobar",'o'));
    }
}
