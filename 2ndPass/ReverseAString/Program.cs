using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringReverse("What hath God wrought?"));
        }

        static string StringReverse(string reverse)
        {
            char[] rev = reverse.ToCharArray();
            Array.Reverse(rev);
            return new string(rev);
        }
    }
}
