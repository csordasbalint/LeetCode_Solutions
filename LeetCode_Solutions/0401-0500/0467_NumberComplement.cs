using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0401_0500
{
    internal class _0467_NumberComplement
    {
        public int FindComplement(int num)
        {
            char[] arr = Convert.ToString(num, 2).ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '0')
                {
                    arr[i] = '1';
                }
                else
                {
                    arr[i] = '0';
                }
            }
            return Convert.ToInt32(new string(arr), 2);
        }

        //Console.WriteLine(FindComplement(5));
    }
}
