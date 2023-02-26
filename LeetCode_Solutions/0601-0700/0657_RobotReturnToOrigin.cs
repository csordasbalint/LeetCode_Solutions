using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._0601_0700
{
    internal class _0657_RobotReturnToOrigin
    {
        public bool JudgeCircle(string moves)
        {
            int numberU = moves.Count(x => x == 'U');
            int numberD = moves.Count(x => x == 'D');
            int numberL = moves.Count(x => x == 'L');
            int numberR = moves.Count(x => x == 'R');

            return (numberU == numberD && numberL == numberR);
        }

        //Console.WriteLine(JudgeCircle("URRDLDUL"));
    }
}
