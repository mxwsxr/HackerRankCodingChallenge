using System;

namespace Day7Arrays
{
    internal class Day7Solution
    {
        private static void Main(string[] args)
        {
            PrintReversedArrElements();
        }

        private static void PrintReversedArrElements()
        {
            Console.ReadLine();

            string str = Console.ReadLine();
            string[] array = str.Split(' ');

            Array.Reverse(array);

            foreach (string num in array)
            {
                Console.Write($"{num} ");
            }
        }
    }
}