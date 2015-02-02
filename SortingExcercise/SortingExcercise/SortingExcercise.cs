using System;
using System.IO;
using System.Linq;

namespace SortingExcercise
{
    internal interface ISortingExcercise
    {
        void Sort(int[] whateves);
    }

    public class ArraySort : ISortingExcercise
    {
        public void Sort(int[] ints)
        {
            Array.Sort(ints);
            string[] intsToStrings = ints.Select(x => x.ToString()).ToArray();

            File.WriteAllLines("c:\\users\\nbrandon\\Desktop\\sortedInts.txt", intsToStrings);
        }
    }

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

    public class MergeSort : ISortingExcercise
    {
        public void Sort(int[] ints)
        {
            Console.WriteLine("Merge Sort");   
        }
    }

    public class SelectionSort : ISortingExcercise
    {
        public void Sort(int[] ints)
        {
            Console.WriteLine("Selection Sort");
        }
    }

    public class QuickSort : ISortingExcercise
    {
        public void Sort(int[] ints)
        {
            Console.WriteLine("Quick Sort");
        }
    }

    public class CountingSort : ISortingExcercise
    {
        public void Sort(int[] ints)
        {
            Console.WriteLine("Counting Sort");
        }
    }

    internal class SortingService
    {
        private readonly ISortingExcercise _sortingExcercise;

        public SortingService(ISortingExcercise sortingExcercise)
        {
            _sortingExcercise = sortingExcercise;
        }

        public void Sort(int[] ints)
        {
            _sortingExcercise.Sort(ints);
        }
    }

    internal class SortingExcercise
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("********* Choose your sort option below: *********");
            Console.WriteLine("1) Array.Sort");
            Console.WriteLine("2) Insertion Sort");
            Console.WriteLine("3) Merge Sort");
            Console.WriteLine("4) Selection Sort");
            Console.WriteLine("5) Quick Sort");
            Console.WriteLine("6) Counting Sort");
            Console.WriteLine();

            Console.Write("Enter option: ");

            int userChoice;
            int.TryParse(Console.ReadLine(), out userChoice);

            string[] lines = File.ReadAllLines(args[0]);
            int[] ints = lines.Select(x => int.Parse(x)).ToArray();


            switch (userChoice)
            {
                case 1:
                    var arraySort = new ArraySort(); 
                    arraySort.Sort(ints);
                    break;
                case 2:
                    var insertionSort = new InsertionSort();
                    insertionSort.Sort(ints);
                    break;
                case 3:
                    var mergeSort = new MergeSort();
                    mergeSort.Sort(ints);
                    break;
                case 4:
                    var selectionSort = new SelectionSort();
                    selectionSort.Sort(ints);
                    break;
                case 5:
                    var quickSort = new QuickSort();
                    quickSort.Sort(ints);
                    break;
                case 6:
                    var countingSort = new CountingSort();
                    countingSort.Sort(ints);
                    break;
            }
        }
    }
}