using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1431_KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            IList<bool> output = new List<bool>();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    output.Add(true);
                }
                else
                {
                    output.Add(false);
                }
            }
            return output;
        }

        //int[] candies = {2,1,2,0,5};
        //IList<bool> tmp = KidsWithCandies(candies, 3);
        //foreach (var item in tmp)
        //{
        //	Console.WriteLine(item);
        //}
    }
}
