using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2101_2200
{
    internal class _2129_CapitalizeTheTitle
    {
        public string CapitalizeTitle(string title)
        {
            char[] tmp;
            string text = title.ToLower();
            string[] shards = text.Split(" ");

            for (int i = 0; i < shards.Length; i++)
            {
                if (shards[i].Length > 2)
                {
                    tmp = shards[i].ToCharArray();
                    tmp[0] = char.ToUpper(tmp[0]);
                    shards[i] = new string(tmp);
                }
            }
            string output = string.Join(" ", shards);
            return output;
        }

        //Console.WriteLine(CapitalizeTitle("capiTalIze tHe titLe"));
    }
}
