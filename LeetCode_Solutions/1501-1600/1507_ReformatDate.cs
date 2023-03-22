using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions._1501_1600
{
    internal class _1507_ReformatDate
    {
        public string ReformatDate(string date)
        {
            date = date.Replace("st", "").Replace("nd", "").Replace("rd", "").Replace("th", "");
            if (date.Length == 11)
            {
                return DateTime.ParseExact(date, "dd MMM yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            }
            return DateTime.ParseExact(date, "d MMM yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
        }

        //Console.WriteLine(ReformatDate("22nd Apr 2023"));
        //Console.WriteLine(ReformatDate("20th Oct 2052"));
    }
}
