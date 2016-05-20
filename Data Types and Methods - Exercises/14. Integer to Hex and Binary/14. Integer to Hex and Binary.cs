using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join("", Hexadecimal(num)));
            Console.WriteLine(string.Join("", Binary(num)));
        }

        private static List<string> Hexadecimal(int num)
        {
            int savenum = num;

            int counter = 0;

            while (num > 0)
            {
                num /= 16;
                counter++;
            }

            string[] remainderArray = new string[counter];

            long remainder = 0;
            for (int i = 0; i < counter; i++)
            {

                remainder = savenum % 16;

                switch (remainder)
                {
                    case 10:
                        remainderArray[i] = "A";
                        break;
                    case 11:
                        remainderArray[i] = "B";
                        break;
                    case 12:
                        remainderArray[i] = "C";
                        break;
                    case 13:
                        remainderArray[i] = "D";
                        break;
                    case 14:
                        remainderArray[i] = "E";
                        break;
                    case 15:
                        remainderArray[i] = "F";
                        break;

                    default: remainderArray[i] = remainder.ToString();
                        break;
                }
                savenum /= 16;
            }
            List<string> n = new List<string>();
            for (int i = remainderArray.Length - 1; i >= 0; i--)
            {

               n.Add(remainderArray[i]);
            }
            return n;
        }
        private static List<int> Binary(int num)
        {
            int remainder;
            int newnum;
            var i = 0;
            List<int> n = new List<int> { };

            while (num != 0)
            {
                remainder = num % 2;
                newnum = num / 2;
                n.Add(remainder);
                i++;
                num = newnum;
            }
            n.Reverse();
            return n;
        }
    }
}
