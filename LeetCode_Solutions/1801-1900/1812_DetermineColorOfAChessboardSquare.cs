using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1801_1900
{
    internal class _1812_DetermineColorOfAChessboardSquare
    {
        public bool SquareIsWhite(string coordinates)
        {
            if ((coordinates[0] + coordinates.Last()) % 2 == 0)
            {
                return false;
            }
            return true;
        }

        //Console.WriteLine(SquareIsWhite("h3"));
    }
}
