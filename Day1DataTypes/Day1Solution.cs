using System;

public class Day1Solution
{
    private static void Main(String[] args)
    {
        ManipulateDataTypes();
    }

    private static void ManipulateDataTypes()
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        // Read and save an integer, double, and String to your variables.
        int secondInt;
        double secondDouble;
        string secondString;

        secondInt = Convert.ToInt32(Console.ReadLine());
        secondDouble = Convert.ToDouble(Console.ReadLine());
        secondString = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + secondInt);
        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:F1}", d + secondDouble);
        // Concatenate and print the String variables on a new line
        Console.Write(s + secondString);
        // The 's' variable above should be printed first.
    }
}