using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Numbers_In_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            ReverseNumber(num);
        }

        private static void ReverseNumber(string num)
        {
            char[] symbols = num.ToCharArray();

            string s = string.Join("", symbols.Reverse());

            Console.WriteLine(string.Join("", s));
        }
    }
}
