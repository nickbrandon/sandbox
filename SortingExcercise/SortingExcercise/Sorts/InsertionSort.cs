using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SortingExcercise.Sorts
{
    public class InsertionSort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            Console.WriteLine("Insertion Sort");
            Console.WriteLine();

            for (int i = 1; i < ints.Length; i++)
            {
                var value = ints[i];  //assign the value of the number at position i (1) to the value variable
                var j = i - 1;  //assign j to the element previous i (the 0th element for the first iteration)
                while ((j >= 0) && ints[j].CompareTo(value) > 0)  //while the value of ints[j] is greater than the value of ints[i]
                {
                    ints[j + 1] = ints[j];  //assign the next element in the array from j to j + 1 
                    j--;  //decrement j (move left down the list)
                }
                ints[j + 1] = value; //finally, assign value to the value of the int at position ints[j+1] 
            }


            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            return null;

        }
    }

}
