using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._2501_2600
{
    internal class _2582_PassThePillow
    {
        public int PassThePillow(int n, int time)
        {
            int current = 1;
            bool changeDir = true;
            while (time != 0)
            {
                if (changeDir)
                {
                    current++;
                    time--;
                    if (current == n)
                    {
                        changeDir = false;
                    }
                }
                else
                {
                    current--;
                    if (current == 1)
                    {
                        changeDir = true;
                    }
                    time--;
                }
            }
            return current;
        }

        //Console.WriteLine(PassThePillow(4,5));
        //Console.WriteLine(PassThePillow(3,2));
    }
}
