using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBytes();
        }

        static void LearningTypeConversions()
        {
            Console.WriteLine("***** Fun with type conversions *****");

            //Add two shorts and print the result.
            short numb1 = 30000, numb2 = 30000;

            //explicitly cast the int into a short (and allow a loss of data)
            short answer = (short)Add(numb1, numb2);

            Console.WriteLine("{0} + {1} = {2}",
                numb1, numb2, answer);
            NarrowingAttempt();
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte mByte = 0;
            int myInt = 200;

            //explicitly cast the int into a byte (no loss of data)
            mByte = (byte)myInt;
            Console.WriteLine("Value of mByte: {0}", mByte);
        }

        static void ProcessBytes()
        {
            int b1 = 100;
            int b2 = 250;
            //byte sum = (byte)Add(b1, b2);

            try 
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // sum should hold the value 350.  However, we find the value 94!
            //Console.WriteLine("sum = {0}", sum);
        }
    }
}
