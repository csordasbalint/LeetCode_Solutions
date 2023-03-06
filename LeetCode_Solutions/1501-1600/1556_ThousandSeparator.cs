using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1501_1600
{
    internal class _1556_ThousandSeparator
    {
        public string ThousandSeparator(int n)
        {
            List<char> list = n.ToString().ToList();
            int tmp = list.Count;
            string output;

            if (tmp <= 3)
            {
                output = string.Join("", list);
                return output;
            }
            while (tmp > 3)
            {
                list.Insert(tmp - 3, '.');
                tmp -= 3;
            }

            output = string.Join("", list);
            return output;
        }


        //Console.WriteLine(ThousandSeparator(987));
        //Console.WriteLine(ThousandSeparator(1234));
        //Console.WriteLine(ThousandSeparator(123456789));
    }
}
