using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingExcercise.Sorts
{
    public class MergeSort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            List<int> listOfInts = ints.ToList();

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

            return Merge(left, right).ToArray();
            
        }

        private IEnumerable<int> Merge(List<int> left, List<int> right)
        {
            var results = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    results.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    results.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                results.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                results.Add(right[0]);
                right.RemoveAt(0);
            }

            //why is this returning correctly here but not when I pass it back to the MergeSort function that calls it?

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            return results;
        }
    }
}