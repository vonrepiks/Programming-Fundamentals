using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            n = FibonacciNumber(n);
        }

        private static double FibonacciNumber(double n)
        {
            var num = 1.00;
            var num1 = 1.00;
            if (n % 2 == 0)
            {
                while (n > 0)
                {
                    num += num1;
                    num1 += num;
                    n -= 2;
                }
                Console.WriteLine("{0:F0}", num);
            }
            else
            {
                while (n > 1)
                {
                    num += num1;
                    num1 += num;
                    n -= 2;
                }
                Console.WriteLine("{0:F0}", num1);
            }
            return n;
        }
    }
}
