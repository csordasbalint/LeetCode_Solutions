using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1301_1400
{
    internal class _1360_NumberOfDaysBetweenTwoDates
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            TimeSpan diff = DateTime.Parse(date2) - DateTime.Parse(date1);
            return Math.Abs((int)diff.TotalDays);
        }


        //Console.WriteLine(DaysBetweenDates("2019-06-29", "2019-06-30"));
        //Console.WriteLine(DaysBetweenDates("2020-01-15", "2019-12-31"));
        //Console.WriteLine(DaysBetweenDates("2020-02-29", "2021-05-15"));
        //Console.WriteLine(DaysBetweenDates("1999-12-31", "2000-01-01"));
    }
}
