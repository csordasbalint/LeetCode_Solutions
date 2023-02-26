using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1301_1400
{
    internal class _1323_Maximum69Number
    {
        public int Maximum69Number(int num)
        {
            char[] arr = num.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '6')
                {
                    arr[i] = '9';
                    break;
                }
            }
            return Convert.ToInt32(new string(arr));
        }

        //Console.WriteLine(Maximum69Number(9669));
    }
}
