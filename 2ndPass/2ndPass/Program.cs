using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndPass
{
    class Program
    {
        private static void Main(string[] args)
        {
            //StringReverse
            //const string reverseMe = "I'm a string.";
            //Console.WriteLine(StringReverse(reverseMe));

            //findInt
            //var intArray = new int[] {1, 2, 4, 5, 9};
            //var answer = FindMissingInts(intArray);

            //for (int i = 0; i < answer.Length; i++)
            //{
            //    Console.WriteLine(answer[i]);
            //}

            //findInt2
            //var intArray = new int[] { 12, 20, 45, 60, 90 };
            //FindMissingInts2(intArray);

            //Factorial
            //Console.WriteLine(Factorial(5));

            //Fibonacci
            Console.WriteLine(Fib(50));
        }


        public static string StringReverse(string reverse)
        {
            char[] theChars = reverse.ToCharArray();
            Array.Reverse(theChars);
            return new string(theChars);
        }

        public static int[] FindMissingInts(int[] sequence)
        {
            var alltheNums = (int[]) Enumerable.Range(sequence.First(), sequence.Last()).ToArray();
            var missingNums = alltheNums.Except(sequence).ToArray();
            return missingNums;
        }

        public static int[] FindMissingInts2(int[] sequenceInts)
        {
            for (int i = sequenceInts.First(); i < sequenceInts.Last(); i++)
            {
                if (!sequenceInts.Contains(i))
                {
                    Console.WriteLine(i);
                }
            }
            return null;
        }

        //use a dictionary to store the value of the previously calculated values to save on processing time- key, value = int for the position, long for the value
        private static Dictionary<int, long> _dictionary = new Dictionary<int, long>();
        //initialize a counter for performance checking
        static long c = new long();

        static long Fib(int n)
        {
            //fibonacci
            //F(0) = 0
            //F(1) = 1
            //F(n) = F(n -1) + F(n -2)

            // 1, 1, 2, 3, 5, 8, 13, 21, 34, 56

            //find the nth position of the Fibonacci sequence

            //why don't I have to assign this long, but I do outside of the method?
            long fibNumber;

            //increment the counter to see how many times the method is hit
            c++;

            if (_dictionary.ContainsKey(n))
            {
                return _dictionary[n];
            }

            if (n == 0)
            {
                return n;
            }
            if (n == 1)
            {
                return n;
            }
            {
                fibNumber = Fib(n - 1) + Fib(n - 2);
            }

            _dictionary.Add(n, fibNumber);
            return _dictionary[n];

        }

        static long Factorial(int n)
        {
            //because 2 * 1  = 2
            if (n > 2)
            {
                return Factorial(n - 1) * n;
            }
            {
                return n;
            }
        }
    }
}
