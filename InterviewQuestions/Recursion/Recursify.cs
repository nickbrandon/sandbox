using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursify
    {
        static int Recursive(int value, ref int count)
        {
            count++;
            //if (value >= 1000)
            //{
            //    //throw new Exception("End");
            //    return value;
            //}
            return Recursive(value + 1, ref count);
        }


        static void Main(string[] args)
        {
            //call the method with 2 params
            //int count = 0;
            //int total = Recursive(50, ref count);

            //Console.WriteLine(total);
            //Console.WriteLine(count);

            Console.WriteLine(Fib(18));
            Console.WriteLine(c);
        }


        static long Factorial(int n)
        {
            if (n > 2)
                return Factorial(n - 1) * n;
            else
            {
                return n;
            }
        }

        //F(0) = 0
        //F(1) = 1
        //F(n) = F(n-1) + F(n-2)

        private static Dictionary<int, long> _dictionary = new Dictionary<int, long>();

        private static long c = 0;

        static long Fib(int n)
        {
            c++;
            if (_dictionary.ContainsKey(n))
                return _dictionary[n];
            long fibCatcher;
            if (n == 0)
            {
                fibCatcher = 0;
            }
            else if (n == 1)
            {
                fibCatcher = 1;
            }
            else
            {
                fibCatcher = Fib(n - 1) + Fib(n - 2);                
            }
            
        _dictionary.Add(n, fibCatcher);
            return fibCatcher;
        }
    }
}
