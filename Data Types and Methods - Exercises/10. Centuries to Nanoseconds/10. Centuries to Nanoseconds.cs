using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());

            var resultYears = centuries * 100;
            var resultDays = (uint)(resultYears * 365.2422);
            var resultHours = resultDays * 24;
            decimal resultMinutes = resultHours * 60;
            decimal resultSeconds = resultMinutes * 60;
            decimal resultMilliseconds = resultSeconds * 1000;
            decimal resultMicroseconds = resultMilliseconds * 1000;
            decimal resultNanoseconds = resultMicroseconds * 1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries,
                resultYears,
                resultDays,
                resultHours,
                resultMinutes, resultSeconds, resultMilliseconds, resultMicroseconds, resultNanoseconds);
        }
    }
}
