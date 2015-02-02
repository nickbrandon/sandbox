using System;

namespace SortingExcercise.Sorts
{
    public class ArraySort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            Array.Sort(ints);
            return ints;
            
            //string[] intsToStrings = ints.Select(x => x.ToString()).ToArray();

            //return intsToStrings.Select(int.Parse).ToArray();
        }
    }
}