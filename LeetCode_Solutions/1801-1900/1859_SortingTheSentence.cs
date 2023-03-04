using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1801_1900
{
    internal class _1859_SortingTheSentence
    {
        public string SortSentence(string s)
        {
            string[] shards = s.Split(" ");
            string output = "";
            var tmp = shards.Select(x => x.ToString()).OrderBy(x => x.Last() - 48);

            foreach (var item in tmp)
            {
                output += (item.Remove(item.Length - 1) + " ");
            }
            string final = output.Remove(output.Length - 1);
            return final;
        }

        //Console.WriteLine(SortSentence("is2 sentence4 This1 a3"));
    }
}
