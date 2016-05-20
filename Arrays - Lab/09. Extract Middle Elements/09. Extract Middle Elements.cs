using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine("{0}", numbers[0]);
            }
            else if (numbers.Length % 2 == 0)
            {
                int firstNum = numbers.Length / 2;

                Console.WriteLine("{0},{1}", numbers[firstNum - 1], numbers[firstNum]);
            }
            else if (numbers.Length % 2 != 0)
            {
                int firstNum = numbers.Length / 2;

                Console.WriteLine("{0},{1},{2}", numbers[firstNum - 1], numbers[firstNum], numbers[firstNum + 1]);
            }
        }
    }
}
