using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace SortingExcercise.Sorts
{
    public class QuickSort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            QuickSorter(ints, 0, ints.Length - 1);
            return ints;
        }

        public int[] QuickSorter(int[] ints, int lo, int hi)
        {
            if (lo < hi)
            {
                var pivot = Partition(ints, lo, hi);

                if (pivot > 1)
                {
                    QuickSorter(ints, lo, pivot - 1);
                }
                if (pivot + 1 < hi)
                {
                    QuickSorter(ints, pivot + 1, hi);
                }

            }
            return ints;
        }

        public int Partition(int[] ints, int lo, int hi)
        {
            var pivotIndex = ints[lo];
            while (true)
            {
                while (ints[lo] < pivotIndex)
                    lo++;

                while (ints[hi] > pivotIndex)
                    hi--;

                //for equal ints in the list
                if (ints[hi] == pivotIndex && ints[lo] == pivotIndex)
                {
                    lo++;
                }

                if (lo < hi)
                {
                    var temp = ints[hi];
                    ints[hi] = ints[lo];
                    ints[lo] = temp;
                }
                else
                {
                    return hi;
                }
            }
        }
    }

}
