using System;
using System.ComponentModel;
using System.Linq;

namespace SortingExcercise.Sorts
{
    //currently not working for a passed in array with negative integers

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
            int[] counts = new int[ints.Max() + 1]; 
            int[] output = new int[ints.Length]; 


            for (int i = 0; i < ints.Length; i++)  //
            {
                counts[ints[i]]++;             
            }

            int j = 0;  

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
