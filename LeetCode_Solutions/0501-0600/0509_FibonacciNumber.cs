using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0501_0600
{
    internal class _0509_FibonacciNumber
    {
        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int tmp = 0;
            int current = 1;
            int previous = 1;

            for (int i = 1; i < n - 1; i++)
            {
                tmp = current + previous;
                previous = current;
                current = tmp;
            }
            return current;
        }

        //Console.WriteLine(Fib(5));

        //int Fib(int n)
        //{
        //	if (n <= 1)
        //	{
        //		return n;
        //	}
        //	return Fib(n - 2) + Fib(n - 1);
        //}
    }
}
