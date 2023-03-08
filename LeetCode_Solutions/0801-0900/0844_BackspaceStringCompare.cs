using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0801_0900
{
    internal class _0844_BackspaceStringCompare
    {
        public bool BackspaceCompare(string s, string t)
        {
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            List<char> sList = new List<char>();
            List<char> tList = new List<char>();

            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != '#')
                {
                    sList.Add(sArray[i]);
                }
                else
                {
                    if (sList.Count > 0)
                    {
                        sList.RemoveAt(sList.Count - 1);
                    }
                }
            }
            for (int i = 0; i < tArray.Length; i++)
            {
                if (tArray[i] != '#')
                {
                    tList.Add(tArray[i]);
                }
                else
                {
                    if (tList.Count > 0)
                    {
                        tList.RemoveAt(tList.Count - 1);
                    }
                }
            }

            return sList.SequenceEqual(tList) && sList.Count == tList.Count;
        }

        //Console.WriteLine(BackspaceCompare("ab###", "#a#b#"));
        //Console.WriteLine(BackspaceCompare("ab#c", "ad#c"));
        //Console.WriteLine(BackspaceCompare("xywrrmp", "xywrrmu#p"));
    }
}
