using System;

namespace Day5Loops
{
    internal class Day5Solution
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = n * i;
                Console.WriteLine(n + " x " + i + " = " + result);
            }
        }
    }
}