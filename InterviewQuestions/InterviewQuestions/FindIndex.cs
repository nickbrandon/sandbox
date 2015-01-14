using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class FindIndex
    {   

        public static int DoTheFindIndex(string[] arr, string findMe)
        {
            //using a for loop
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == findMe)
                {
                    return i;    
                }
            }
            return -1;

            //using foreach

            //var index = 0;
            //foreach (var myString in arr)
            //{
            //    if (myString == findMe)
            //    {
            //        return index;
            //    }
            //    index++;
            //}
            //return -1;


            //using IndexOf
            //var index = Array.IndexOf(arr, findMe);
            //return index;
        }        
    }
}
