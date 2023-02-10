using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2011_FinalValueOfVariableAfterPerformingOperations
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "++X" || operations[i] == "X++")
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
            return x;
        }

        //string[] ops = {"++X","--X","X--","X++","X++","X++","++X"};
        //Console.WriteLine(FinalValueAfterOperations(ops));
    }
}
