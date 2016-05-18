namespace Arrays
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string line = command.Trim();
                int[] args = new int[2];

                if (command.Contains("add") ||
                    command.Contains("subtract") ||
                    command.Contains("multiply"))
                {
                    string[] stringParams = line.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);
                }

                PerformAction(array, command, args);

                PrintArray(array);

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string command, int[] args)
        {
            int pos = args[0] - 1;
            int value = args[1];
            string[] action = command.Split().ToArray();

            switch (action[0])
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            var num = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = num;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            var num = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = num;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
