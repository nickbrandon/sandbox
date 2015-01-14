using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{

    static class foo
    {
        static void blah()
        {
            string s = "sssssss";
            s.LookMaReversedExtensionMethods();
        }
    } 

    static class StringReverse
    {
        private static Dictionary<int, string> _dictionary = new Dictionary<int, string>();


        public static string LookMaReversedExtensionMethods(this string value)
        {
            //way #2
            char[] arr = value.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }



        public static string Reverse(string reverseMe)
        {
            //way #1
            //var myArray = reverseMe.ToCharArray();
            //var sb = "";

            //for (int i = myArray.Length - 1; i >= 0; i--)
            //{
            //    sb += myArray[i];
            //}
            //return sb;



            //way #2
            char[] arr = reverseMe.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);





            //way #3 - recursively
                //take the last letter of the string using substring and a counter 
                //repeat until the counter is at 0
                //return the newly built backwards string



            //the most succint way to do it
            //return reverseMe == string.Empty ? "" : Reverse(reverseMe.Substring(1)) + reverseMe.Substring(0, 1);



            //int x = reverseMe.Length;

            //if (reverseMe == string.Empty)
            //{
            //    return string.Empty;
            //}

            //char s = '\0';

            //if (x <= reverseMe.Length)
            //{
            //    s = reverseMe[x - 1];
            //}

            //return s + Reverse(reverseMe.Substring(0, x - 1));

        }
    }
}
