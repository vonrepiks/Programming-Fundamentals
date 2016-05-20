using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(number));

        }
        static Boolean isPrime(long number)
        {
            if (number == 0) return false;
            if (number == 1) return false;     

            for (int i = 2; i <= Math.Sqrt(number); i ++)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
    }
}
