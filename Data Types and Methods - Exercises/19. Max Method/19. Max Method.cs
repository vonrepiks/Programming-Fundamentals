using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            GetMaxNumber(num1, num2, num3);
        }

        private static void GetMaxNumber(int num1, int num2, int num3)
        {
            int[] numbers = { num1, num2, num3 };

            Console.WriteLine(numbers.Max());
        }
    }
}
