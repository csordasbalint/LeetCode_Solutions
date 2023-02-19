using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1108_DefangingAnIPAddress
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        //Console.WriteLine(DefangIPaddr("8.8.8.8"));
    }
}
