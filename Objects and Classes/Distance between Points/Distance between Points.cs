using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputP1 = Console.ReadLine();
            string inputP2 = Console.ReadLine();

            int[] point1Coord = inputP1.Split(' ').Select(int.Parse).ToArray();
            int[] pointC2oord = inputP2.Split(' ').Select(int.Parse).ToArray();

            Point p1 = new Point() { x = point1Coord[0], y = point1Coord[1] };

            Point p2 = new Point() { x = pointC2oord[0], y = pointC2oord[1] };

            //Console.WriteLine("{0:f3}", CalcDistance(p1, p2));

            //var inputP1 = Console.ReadLine()
            //    .Split(' ')
            //    .Select(double.Parse)
            //    .ToArray();

            //var inputP2 = Console.ReadLine()
            //    .Split(' ')
            //    .Select(double.Parse)
            //    .ToArray();

            //var c = 0.0;

            //var a = Math.Abs(inputP1[0] - inputP2[0]);
            //var b = Math.Abs(inputP1[1] - inputP2[1]);

            //c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("{0:f3}", CalcDistance(p1, p2));

        }

        private static double CalcDistance(Point p1, Point p2)
        {
            double c = 0.0;
            int a = Math.Abs(p2.x - p1.x);
            int b = Math.Abs(p2.y - p1.y);

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return c;
        }

            class Point
            {
                public int x { get; set; }

                public int y { get; set; }
            }
    }
}
