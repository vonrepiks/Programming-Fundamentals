using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var indexStart = int.Parse(Console.ReadLine());
            var indexEnd = int.Parse(Console.ReadLine());

            var length = indexEnd - indexStart;

            Char[] sequence = new Char[length + 1];

            for (int i = 0; i <= length; i++)
            {
                sequence[i] = Convert.ToChar(indexStart);
                indexStart++;
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
