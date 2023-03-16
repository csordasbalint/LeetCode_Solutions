using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1401_1500
{
    internal class _1408_StringMatchingInAnArray
    {
        public IList<string> StringMatching(string[] words)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i != j && words[j].Contains(words[i]))
                    {
                        if (!list.Contains(words[i]))
                        {
                            list.Add(words[i]);
                        }
                    }
                }
            }

            return list;
        }

        //string[] arr = { "mass", "as", "hero", "superhero" };
        //IList<string> outputStrings = StringMatching(arr);
        //foreach (var item in outputStrings)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
