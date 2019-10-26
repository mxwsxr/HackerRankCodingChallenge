using System;
using System.Collections.Generic;
using System.IO;

namespace Day8DictionariesMaps
{
    internal class Day8Solution
    {
        private static void Main(string[] args)
        {
            // Specifies the amount of entries you want to have in the telephonebook.
            int telephoneBookEntryAmount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> TelephoneBook = new Dictionary<string, int>(telephoneBookEntryAmount);

            // Iterate through the entry amount and describe each entry in the form of 2 space-separated values on a single line.
            for (int i = 0; i < telephoneBookEntryAmount; i++)
            {
                string[] telephoneBookEntry = Console.ReadLine().Split(" ");
                int digitLength = 8;
                if (telephoneBookEntry[1].Length == digitLength)
                {
                    TelephoneBook.Add(telephoneBookEntry[0], Convert.ToInt32(telephoneBookEntry[1]));
                }
                else
                {
                    Console.WriteLine("Please provide a phone number with a valid digit length of 8!");
                }
            }

            // Iterate through the entry amount and search for any key in the dictionary.
            // If found then print the query as name=phonenumber.
            for (int i = 0; i < telephoneBookEntryAmount; i++)
            {
                string entrySearch = Console.ReadLine();

                if (TelephoneBook.ContainsKey(entrySearch) && entrySearch.Length != 0)
                {
                    Console.WriteLine($"{entrySearch}={TelephoneBook[entrySearch]}");
                }
                else
                {
                    Console.WriteLine("Not found!");
                }
            }
        }
    }
}