using System;
using System.Linq;

namespace BinarySearchOnStrings
{
    class BinarySearchOnStrings
    {
        static void Main(string[] args)
        {
            string[] someStrings = {"Nick", "John", "Fred", "Sam", "Frank", "Joe", "Harold", "Frodo", "Tom", "Micah"};
            var sortedStrings = someStrings.OrderBy(s => s).ToArray();
            var noStrings = new string[0];
            string[] oneString = { "Sam" };
            Array.ForEach(sortedStrings,Console.WriteLine);
            Console.WriteLine(BinarySearch(sortedStrings, "Frodo"));
        }

        static bool BinarySearch(string[] strings, string stringToMatch)
        {
            if (strings.Length == 0)
            {
                return false;
            }
            
            int midPointElement = strings.Length/2;

            if (strings[midPointElement].CompareTo(stringToMatch) == 0)
            {
                return true;
            }
            if (strings[midPointElement].CompareTo(stringToMatch) > 0)
            {
                string[] newSearchStrings = strings.Take(midPointElement).ToArray();
                return BinarySearch(newSearchStrings, stringToMatch);
            }
            else //if (strings[midPointElement].CompareTo(stringToMatch) < 0)
            {
                string[] newSearchStrings = strings.Skip(midPointElement).ToArray();
                return BinarySearch(newSearchStrings, stringToMatch);
            }

            
        } 
    }

  
}
