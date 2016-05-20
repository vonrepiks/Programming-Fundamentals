using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            int cols = 2;

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = cells[col];
                }
            }

            int row1 = 0;
            int col1 = 0;

            List<double> diagonals = new List<double>();
            for (int i = 0; i < rows; i++)
            {
                row1 = i;
                for (int j = i; j < rows - 1; j++)
                {
                    double diagonal = Math.Sqrt(Math.Pow(Math.Abs((double)matrix[i, col1] - matrix[row1 + 1, col1]), 2) + Math.Pow(Math.Abs((double)matrix[i, col1 + 1] - matrix[row1 + 1, col1 + 1]), 2));
                    row1++;
                    diagonals.Add(diagonal);
                }
            }

            double diagonalMin = diagonals.Min();

            Console.WriteLine("{0:f3}", diagonalMin);

            bool flag = false;
            for (int i = 0; i < rows; i++)
            {
                row1 = i;
                for (int j = i; j < rows - 1; j++)
                {
                    if (diagonalMin == Math.Sqrt(Math.Pow(Math.Abs((double)matrix[i, col1] - matrix[row1 + 1, col1]), 2) + Math.Pow(Math.Abs((double)matrix[i, col1 + 1] - matrix[row1 + 1, col1 + 1]), 2)))
                    {
                        Console.WriteLine("({0}, {1})", matrix[i, col1], matrix[i, col1 + 1]);
                        Console.WriteLine("({0}, {1})", matrix[row1 + 1, col1], matrix[row1 + 1, col1 + 1]);
                        flag = true;
                        break;
                    }
                    row1++;
                }
                if (flag)
                {
                    break;
                }
            }   
        }
    }
}
