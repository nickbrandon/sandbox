using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingExcercise.Sorts
{
    public class MergeSort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            //convert ints[] to List
            List<int> listOfInts = ints.ToList();


            //3 arrays for holding values
            var result = new List<int>();
            var left = new List<int>();
            var right = new List<int>();

            if (listOfInts.Count <= 1)
            {
                return ints;
            }

            int midpoint = listOfInts.Count/2;
            for (int i = 0; i < midpoint; i++)
            {
                left.Add(listOfInts[i]);
            }
            for (int i = midpoint; i < listOfInts.Count(); i++)
            {
                right.Add(listOfInts[i]);
            }

            int[] leftArray = left.ToArray();
            left = Sort(leftArray).ToList();

            int[] rightArray = right.ToArray();
            right = Sort(rightArray).ToList();
            result = Merge(left, right).ToList();


            Console.WriteLine("Merge Sort");

            return result.ToArray();
        }


        private List<int> Merge(object left, object right)
        {
            throw new NotImplementedException();
        }
    }
}

// take in unordered array
// divide it in 2 until there are n sets of 2 elements (an odd element can be in its own set)
// take each set(n) and do a compare, swapping the values if necessary