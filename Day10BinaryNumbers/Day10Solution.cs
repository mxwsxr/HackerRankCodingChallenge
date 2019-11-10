using System;
using System.Linq;

namespace Day10BinaryNumbers
{
    internal class Day10Solution
    {
        /// <summary>
        /// https://davidzych.com/converting-an-int-to-a-binary-string-in-c/
        /// We use Convert.ToString(n, 2) in here to take input n
        /// and convert it to binary base-2.
        /// Furthermore, Split takes the string and removes the 0s.
        /// .Max gives the max of the consecutive 1s
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine(
                Convert.ToString(
                    Convert.ToInt32(Console.ReadLine()), 2)
                .Split('0')
                .Max(binary => binary.Length)
                );
        }
    }
}