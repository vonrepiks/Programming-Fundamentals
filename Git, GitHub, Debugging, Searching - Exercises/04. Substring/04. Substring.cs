namespace Debugging_Substring
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Substring_broken
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            List<char> text1 = text.ToList();
            const char Search = 'p';
            bool hasMatch = false;
            

            while(text1.Count > 0)
            {
                text = string.Join("", text1.ToArray());
                var j = 0;
                if (text[0] == Search)
                {
                    hasMatch = true; 

                    int endIndex = jump;

                    if (endIndex > text.Length)
                    {
                        endIndex = text.Length;
                    }
                    else
                    {
                        endIndex++;
                    }
                    if (text.Length < endIndex)
                    {
                        endIndex = text.Length;
                    }

                    string matchedString = text.Substring(0, endIndex);
                    Console.WriteLine(matchedString);
                    j += jump - 1;
                    
                }
                j++;
                if (j == 0)
                {
                    j++;
                }
                text1.RemoveRange(0, j);
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
