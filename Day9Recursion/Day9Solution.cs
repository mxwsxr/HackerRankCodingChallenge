using System;

namespace Day9Recursion
{
    public class Day9Solution
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(n);

            Console.WriteLine(result);
        }

        private static int Factorial(int n)
        {
            return n == 1 ? 1 : n * Factorial(n - 1);
        }
    }
}