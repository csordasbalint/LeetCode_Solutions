using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _2469_ConvertTheTemperature
    {
        private double[] ConvertTemperature(double celsius)
        {
            double[] ans = new double[2];

            ans[0] = Math.Round(celsius + 273.15, 4);
            ans[1] = Math.Round(celsius * 1.8 + 32, 4);

            return ans;
        }

        //var tmp = ConvertTemperature(122.11);
        //for (int i = 0; i<tmp.Length; i++)
        //{
        //    Console.WriteLine(tmp[i]);
        //}
    }
}
