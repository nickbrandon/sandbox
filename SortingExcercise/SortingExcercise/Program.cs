using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortingExcercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"numbers.txt");
            ArraySort(lines);
        }

        public static void ArraySort(string[] strings)
        {
            var intstrings = strings.Select(x => int.Parse(x)).ToArray();
            Array.Sort(intstrings);

            foreach (var s in intstrings)
            {
                Console.WriteLine(s);
            }
        }
    }
}