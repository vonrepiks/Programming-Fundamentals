using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isNo = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int b = arr[j];
                    int sum = a + b;
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        isNo = false;
                    }
                }
            }
            if (isNo)
            {
                Console.WriteLine("No");
            }
        }
    }
}
