using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1001_1100
{
    internal class _1009_ComplementOfBase10Integer
    {
        public int BitwiseComplement(int n)
        {
            string toBinary = Convert.ToString(n, 2);
            char[] arr = toBinary.ToCharArray();
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

            string toConvert = new string(arr);
            return Convert.ToInt32(toConvert, 2);
        }


        //Console.WriteLine(BitwiseComplement(5));
    }
}
