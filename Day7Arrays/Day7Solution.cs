using Day7Arrays.Helper;
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

            ArrayReverser.DoReversal(array);

            foreach (string num in array)
            {
                Console.Write($"{num} ");
            }
        }

        //public static string ReverseString(string myString)
        //{
        //    char[] chars = new char[myString.Length];

        //    for (int i = 0, j = myString.Length - 1; i <= j; i++, j--)
        //    {
        //        chars[i] = myString[j];
        //        chars[j] = myString[i];
        //    }
        //    return new string(chars);
        //}
    }
}