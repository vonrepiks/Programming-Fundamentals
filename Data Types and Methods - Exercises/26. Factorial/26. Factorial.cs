using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            n = BigInteger(n);
        }

        private static int BigInteger(int n)
        {
            BigInteger num = 1;

            //long num = 1;

            while (n > 0)
            {
                num *= n;
                n--;
            }

            Console.WriteLine(num);
            return n;
        }
    }
}
