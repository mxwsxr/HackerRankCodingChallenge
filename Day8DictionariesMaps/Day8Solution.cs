using System;
using System.Collections.Generic;
using System.IO;

namespace Day8DictionariesMaps
{
    public class Day8Solution
    {
        private static void Main(string[] args)
        {
            var consoleIO = new ConsoleImpl();
            Execute(consoleIO);
        }

        public static void Execute(ICommInterface commInterface)
        {
            // Specifies the amount of entries you want to have in the telephonebook.
            int telephoneBookEntryAmount = Convert.ToInt32(commInterface.ReadLine());

            Dictionary<string, int> TelephoneBook = new Dictionary<string, int>(telephoneBookEntryAmount);

            // Iterate through the entry amount and describe each entry in the form of 2 space-separated values on a single line.
            for (int i = 0; i < telephoneBookEntryAmount; i++)
            {
                string[] telephoneBookEntry = commInterface.ReadLine().Split(' ');
                int digitLength = 8;
                if (telephoneBookEntry[1].Length == digitLength)
                {
                    TelephoneBook.Add(telephoneBookEntry[0], Convert.ToInt32(telephoneBookEntry[1]));
                }
                else
                {
                    commInterface.WriteLine("This is not a 8 digit phone number!");
                    return;
                }
            }

            // Iterate through the entry amount and search for any key in the dictionary.
            // If found then print the query as name=phonenumber.
            while (true)
            {
                string entrySearch = commInterface.ReadLine();

                if (!string.IsNullOrWhiteSpace(entrySearch))
                {
                    if (TelephoneBook.ContainsKey(entrySearch) && entrySearch.Length != 0)
                    {
                        commInterface.WriteLine($"{entrySearch}={TelephoneBook[entrySearch]}");
                    }
                    else
                    {
                        commInterface.WriteLine("Not found");
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}