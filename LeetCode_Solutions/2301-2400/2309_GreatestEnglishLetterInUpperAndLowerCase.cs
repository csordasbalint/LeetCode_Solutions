using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2301_2400
{
    internal class _2309_GreatestEnglishLetterInUpperAndLowerCase
    {
        public string GreatestLetter(string s)
        {
            List<char> list = new List<char>();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 65 && arr[i] <= 90)
                {
                    list.Add(arr[i]);
                }
            }
            list.Sort((x, y) => y.CompareTo(x));
            foreach (var item in list)
            {
                if (s.Contains(item.ToString().ToLower()))
                {
                    return item.ToString();
                }
            }

            return "";
        }


        //Console.WriteLine(GreatestLetter("lEeTcOdE"));
        //Console.WriteLine(GreatestLetter("AbCdEfGhIjK"));
    }
}
