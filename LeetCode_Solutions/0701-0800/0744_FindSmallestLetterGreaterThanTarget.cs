using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0701_0800
{
    internal class _0744_FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > target)
                {
                    return letters[i];
                }
            }

            return letters[0];
        }


        //char[] arr = { 'c', 'f', 'j' };
        //char[] arr2 = { 'c', 'f', 'j' };
        //char[] arr3 = { 'x', 'x', 'y' , 'y' };
        //Console.WriteLine(NextGreatestLetter(arr,'a'));
        //Console.WriteLine(NextGreatestLetter(arr2, 'c'));
        //Console.WriteLine(NextGreatestLetter(arr3, 'z'));
    }
}
