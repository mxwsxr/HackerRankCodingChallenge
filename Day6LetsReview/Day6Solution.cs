using System;
using System.Collections.Generic;
using System.IO;

namespace Day6LetsReview
{
    internal class Day6Solution
    {
        private static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string str = Console.ReadLine();

                for (int j = 0; j < str.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(str[j]);
                    }
                }
                Console.Write(" ");

                for (var j = 0; j < str.Length; j++)
                {
                    if (j % 2 != 0) Console.Write(str[j]);
                }

                Console.Write(Environment.NewLine);
            }
        }
    }
}