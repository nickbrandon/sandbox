using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortingExcercise
{
    internal class SortingExcercise
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("********* Choose your sort option below: *********" );
            Console.WriteLine("1) Array.Sort" );
            Console.WriteLine("2) Insertion Sort" );
            Console.WriteLine("3) Merge Sort" );
            Console.WriteLine("4) Selection Sort" );
            Console.WriteLine("5) Quick Sort" );
            Console.WriteLine("6) Counting Sort" );
            Console.WriteLine();

            Console.Write("Enter option: ");

            int userChoice;
                int.TryParse(Console.ReadLine(), out userChoice);
            
            var lines = File.ReadAllLines(args[0]);

            switch (userChoice)
            {
                case 1:
                    ArraySort(lines);
                    break;
                case 2:
                    InsertionSort(lines);
                    break;
                case 3:
                    MergeSort(lines);
                    break;
                case 4:
                    SelectionSort(lines);
                    break;
                case 5:
                    QuickSort(lines);
                    break;
                case 6:
                    CountingSort(lines);
                    break;
            }

        }

        public static void ArraySort(string[] strings)
        {
            var stringsToInts = strings.Select(x => int.Parse(x)).ToArray();
            Array.Sort(stringsToInts);
            string[] intsToStrings = stringsToInts.Select(x => x.ToString()).ToArray();


            File.WriteAllLines("c:\\users\\nbrandon\\Desktop\\sortedInts.txt", intsToStrings);
        }

        public static void InsertionSort(string[] strings)
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

        public static void MergeSort(string[] strings)
        {
            Console.WriteLine("Insertion Sort");
        }

        public static void SelectionSort(string[] strings)
        {
            Console.WriteLine("Selection Sort");
        }

        public static void QuickSort(string[] strings)
        {
            Console.WriteLine("Quick Sort");
        }

        public static void CountingSort(string[] strings)
        {
            Console.WriteLine("Counting Sort");
        }

    }
}