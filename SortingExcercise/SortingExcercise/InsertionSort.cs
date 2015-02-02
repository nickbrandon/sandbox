using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExcercise
{
    public class InsertionSort : ISortingExcercise
    {
        public void Sort(int[] ints)
        {
            //start with result as first element of input

            //loop over the input until empty, "removing" the first remaining element

            //compare removed element against current result, starting from the highest (rightmost) element and working left towards the lowest element

            //if the removed input element is lower that the current result element, copy that value into the following element to make room for the
            //new element below, and repeat with the next lowest element

            //otherwise the new element is in the correct location; save it in the cell left by copying the last examined result up, and start again from
            //(2) with the next element

            Console.WriteLine("Insertion Sort");
        }
    }

}
