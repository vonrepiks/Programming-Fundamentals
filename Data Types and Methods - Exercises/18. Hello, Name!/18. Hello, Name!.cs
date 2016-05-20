using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            PrintRegard(name);
        }

        private static void PrintRegard(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
