﻿using System;

namespace Day9Recursions
{
    internal class Day9Solution
    {
        private static void Main(string[] args)
        {
            // comment marked to fulfill hackerrank requirement

            //Console.WriteLine("Enter your Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(n);

            //Console.WriteLine("\nFactorial of your Number is: " + result);
            Console.WriteLine(result);
        }

        private static int Factorial(int n)
        {
            return n == 1 ? 1 : n * Factorial(n - 1);
        }
    }
}