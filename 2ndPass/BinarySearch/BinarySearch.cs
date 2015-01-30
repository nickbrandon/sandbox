using System;
using System.Linq;

namespace BinarySearch
{
    internal class BinarySearch
    {
        private static void Main(string[] args)
        {
            int[] someInts = Enumerable.Range(20, 170).ToArray();
            //Console.WriteLine(BinarySearcher(someInts, 4));
            Console.WriteLine(BinarySearcher(someInts, 37));
            //Console.WriteLine(BinarySearcher(someInts, 190));
            //Console.WriteLine(BinarySearcher(someInts, 113));
            //Console.WriteLine(BinarySearcher(someInts, 149));
            //Console.WriteLine(BinarySearcher(someInts, 99));
        }

        //take a sorted array of ints and use binary search to locate the passed in values


        //TODO: change to use strings and return a bool
        public static int BinarySearcher(int[] values, int searchItem)
        {
            if (values.Length == 0)
            {
                return -1;
            }
            if (values.Length == 1)
            {
                if (values[0] == searchItem)
                {
                    return values[0];
                }
            }




            int midPointElement = (values.Length/2) + 1;

            if (midPointElement == searchItem)
            {
                return searchItem;
            }
            if (midPointElement > searchItem)
            {
                int[] oneHalf = values.Take((values.Length/2) + 1).ToArray();
                return BinarySearcher(oneHalf, searchItem);
            }
            else //(midPointElement < searchItem)
            {
                int[] theOtherHalf = values.Skip((values.Length/2)+
                    1).ToArray();
                return BinarySearcher(theOtherHalf, searchItem);
            }
        }
    }
}