using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1001_1100
{
    internal class _1078_OccurrencesAfterBigram
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            List<string> list = new List<string>();
            string[] shards = text.Split(" ");
            for (int i = 0; i < shards.Length - 2; i++)
            {
                if (shards[i] == first && shards[i + 1] == second)
                {
                    list.Add(shards[i + 2]);
                }
            }
            string[] output = list.ToArray();
            return output;
        }


        //string[] tmp = FindOcurrences("we will we will rock you","we","will");
        //foreach (var item in tmp)
        //{
        //	Console.WriteLine(item);
        //}
    }
}
