using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace SortingExcercise.Sorts
{
    public class MergeSort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            //convert ints[] to List
            var listOfInts = ints.ToList();
            
            
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
            for (int i = 0; i < ints.Count(); i++)
            {
                right.Add(listOfInts[i]);
            }

            int[] leftArray = left.ToArray();


            //can I recursively call this function if I'm doing a list conversion?

            left = Sort(leftArray);
            
            //right = Sort(right);
            //result = Merge(left, right);


            Console.WriteLine("Merge Sort");
            return null;
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