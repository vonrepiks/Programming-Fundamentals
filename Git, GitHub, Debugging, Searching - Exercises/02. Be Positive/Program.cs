namespace BePositive
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BePositiveMain
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }

                bool found = false;
                bool found1 = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                        found1 = true;
                    }
                    else
                    {
                        if (numbers.Count == 1)
                        {
                            currentNum += numbers[j];

                            if (currentNum >= 0)
                            {
                                if (found)
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(currentNum);

                                found = true;
                                found1 = true;
                            }
                            j++;
                        }
                        else
                        {
                            if (j + 1 >= numbers.Count)
                            {
                                continue;
                            }
                            currentNum += numbers[j + 1];

                            if (currentNum >= 0)
                            {
                                if (found)
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(currentNum);

                                found = true;
                                found1 = true;
                            }
                            j++;
                        }
                    }
                }

                if (found)
                {
                    Console.WriteLine();
                }
                if (found1 == false)
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}