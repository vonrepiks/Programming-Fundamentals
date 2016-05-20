using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == 0 || firstNumber == 1)
            {
                firstNumber = 2;
                PrimeNumbersInRange(firstNumber, secondNumber);
            }
            else
            {
                PrimeNumbersInRange(firstNumber, secondNumber);
            }
        }

        private static void PrimeNumbersInRange(int firstNumber, int secondNumber)
        {

            List<int> primes = new List<int>();

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", primes));
        }
    }
}
        


