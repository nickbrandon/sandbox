using System;
using System.ComponentModel;
using System.Linq;

namespace SortingExcercise.Sorts
{

    public class CountingSort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            var testArray = new int[] {-11, 34, 5, 2, 13, 8, 9, 10};
            CountingSorter(testArray);
            Console.WriteLine("Counting Sort");
            return null;
        }

        private void CountingSorter(int[] ints)
        {
            int[] counts = new int[ints.Max() + 1];  //create an array of ints called count that contains n items of 0 that is the length of the maximum integer in the array that is passed in
            int[] output = new int[ints.Length]; // intialize an array of the same length as the input array

            for (int i = 0; i < ints.Length; i++)  //
            {
                counts[ints[i]]++; // the position in the count array of ints[i] 
            }

            int j = 0;  //initialize another counter


            for (int i = 0; i < counts.Length; i++)
            {
                while (counts[i] > 0)
                {
                    output[j] = i;
                    j++;
                    counts[i]--;
                }
            }

            foreach (var i in output)
            {
                Console.WriteLine(i);
            }
        }

    }

}
