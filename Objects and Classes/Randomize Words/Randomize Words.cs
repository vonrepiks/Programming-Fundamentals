using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(" ", text));

            //Random rand = new Random();

            //int a = text.Count;

            //for (int i = 0; i < a; i++)
            //{
            //    int randomIndex = rand.Next(0, text.Count - 1);
            //    Console.WriteLine(text[randomIndex]);
            //    text.RemoveAt(randomIndex);

            //}
        }
    }
}
