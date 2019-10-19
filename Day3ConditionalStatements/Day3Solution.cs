using System;

public class Day3Solution
{
    private static void Main(string[] args)
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