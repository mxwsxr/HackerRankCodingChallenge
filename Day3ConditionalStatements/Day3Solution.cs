using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Day3Solution
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        CheckWeirdness(N);
    }

    private static void CheckWeirdness(int N)
    {
        bool isNEven = N % 2 == 0;

        bool range = N >= 2 && N <= 5;
        bool range2 = N >= 6 && N <= 20;
        bool range3 = N > 20;
        //IEnumerable<int> range = Enumerable.Range(0, 11);

        if (isNEven && range)
        {
            Console.WriteLine("Not Weird");
        }
        else if (isNEven && range2)
        {
            Console.WriteLine("Weird");
        }
        else if (isNEven && range3)
        {
            Console.WriteLine("Not Weird");
        }
        else
        {
            Console.Write("Weird");
        }
    }
}
