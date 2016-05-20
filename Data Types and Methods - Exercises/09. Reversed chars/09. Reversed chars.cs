using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = 2;
            char[] result = new char[3];

            for (int i = 0; i < 3; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                result[j] = letter;
                j--;
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
