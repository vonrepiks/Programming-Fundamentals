using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            float totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float totalHours = (float)hours + (float)minutes / (float)60 + (float)seconds / (float)3600;
            float kiloMeters = distance / 1000;
            float miles = (float)kiloMeters / (float)1.609;

            Console.WriteLine("{0}", (float)distance / (float)totalSeconds);
            Console.WriteLine("{0}", (float)kiloMeters / (float)totalHours);
            Console.WriteLine("{0}", miles / totalHours);
        }
    }
}
