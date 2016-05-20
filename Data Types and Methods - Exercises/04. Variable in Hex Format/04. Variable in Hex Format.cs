using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string numInHex = Console.ReadLine();

            Console.WriteLine("{0}", Convert.ToInt32(numInHex, 16));
        }
    }
}
