using System;

namespace SortingExcercise.Sorts
{
    public class ArraySort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            Array.Sort(ints);
            return ints;
        }
    }
}