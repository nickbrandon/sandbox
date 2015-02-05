using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SortingExcercise.Sorts;

namespace SortingExcercise
{
    internal interface ISortingExcercise
    {
        int[] Sort(int[] ints);
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
            int[] ints = lines.Select(int.Parse).ToArray();


            switch (userChoice)
            {
                case 1:
                    var arraySort = new ArraySort(); 
                    arraySort.Sort(ints);
                    SaveValues(ints);
                    break;
                case 2:
                    var insertionSort = new InsertionSort();
                    insertionSort.Sort(ints);
                    SaveValues(ints);
                    break;
                case 3:
                    var mergeSort = new MergeSort();
                    var sortedInts = mergeSort.Sort(ints);
                    SaveValues(sortedInts);
                    break;
                case 4:
                    var selectionSort = new SelectionSort();
                    selectionSort.Sort(ints);
                    SaveValues(ints);
                    break;
                case 5:
                    var quickSort = new QuickSort();
                    quickSort.Sort(ints);
                    SaveValues(ints);
                    break;
                case 6:
                    var countingSort = new CountingSort();
                    countingSort.Sort(ints);
                    break;
            }
        }

        private static void SaveValues(int[] ints)
        {
            var fileName = "c:\\users\\nbrandon\\Desktop\\sortedInts.txt";
            string[] stringInts = ints.Select(x => x.ToString()).ToArray();
            File.WriteAllLines(fileName, stringInts);
        }
    }
}