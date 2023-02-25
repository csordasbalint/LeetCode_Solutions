using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0501_0600
{
    internal class _0557_ReverseWordsInAString3
    {
        public string ReverseWords(string s)
        {
            char[] arr = s.ToCharArray();
            List<char> tmp = new List<char>();
            List<char> final = new List<char>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ')
                {
                    tmp.Reverse();
                    final.AddRange(tmp);
                    final.Add(arr[i]);
                    tmp.Clear();
                }
                else
                {
                    tmp.Add(arr[i]);
                }
            }
            tmp.Reverse();
            final.AddRange(tmp);
            string output = string.Join("", final);

            return output;
        }

        //Console.WriteLine(ReverseWords("Big Data"));
    }
}
