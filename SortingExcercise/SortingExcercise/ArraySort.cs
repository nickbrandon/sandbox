using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExcercise
{
    public class ArraySort : ISortingExcercise
    {
        public void Sort(int[] ints)
        {
            Array.Sort(ints);
            string[] intsToStrings = ints.Select(x => x.ToString()).ToArray();

            File.WriteAllLines("c:\\users\\nbrandon\\Desktop\\sortedInts.txt", intsToStrings);
        }
    }
}