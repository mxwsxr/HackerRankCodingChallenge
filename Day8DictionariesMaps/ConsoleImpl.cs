using System;
using System.Collections.Generic;
using System.Text;

namespace Day8DictionariesMaps
{
    public class ConsoleImpl : ICommInterface
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}
