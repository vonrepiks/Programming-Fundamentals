using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (numbers.Count > 1)
            {
                int temp;
                List<int> tempNumbers = new List<int>();

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    temp = numbers[i] + numbers[i + 1];
                    tempNumbers.Add(temp);
                }
                numbers = tempNumbers;
            }

            Console.WriteLine(string.Join("", numbers));
        }
    }
}
