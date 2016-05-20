using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.English_Name_Of_The_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            LastNumberInWord(num);
        }

        private static void LastNumberInWord(string num)
        {
            char[] num1 = num.ToCharArray();

            char last = num1[num.Length - 1];

            switch (last)
            {
                case '1': Console.WriteLine("one");
                    break;
                case '2': Console.WriteLine("two");
                    break;
                case '3': Console.WriteLine("three");
                    break;
                case '4': Console.WriteLine("four");
                    break;
                case '5': Console.WriteLine("five");
                    break;
                case '6': Console.WriteLine("six");
                    break;
                case '7': Console.WriteLine("seven");
                    break;
                case '8': Console.WriteLine("eight");
                    break;
                case '9': Console.WriteLine("nine");
                    break;
                default: Console.WriteLine("zero");
                    break;
            }
        }
    }
}
