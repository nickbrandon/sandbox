using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindMissingInts
{
    class FindMissingInts
    {
        static void Main(string[] args)
        {
            List<int> myInts = new List<int>(){1,3,6,7,9,14,18};
            FindMissingInts2(myInts);

        }

        static int[] FindMissing(List<int> sequence)
        {
            //init an array of all numbers starying with 0 to the size of passed in array
            int[] myNums = Enumerable.Range(1, sequence.Last()).ToArray();

            var s3 = myNums.Except(sequence);

            foreach (var s in s3)
            {
                Console.WriteLine(s.ToString());
            }
            
            
            return null;
        }

        static int[] FindMissingInts2(List<int> sequence)
        {
            for (int i = sequence.First(); i < sequence.Last() ; i++)
            {
                if (!sequence.Contains(i))
                {
                    Console.Write(i + ", ");
                }

            }
            return null;
        }

    }
}
