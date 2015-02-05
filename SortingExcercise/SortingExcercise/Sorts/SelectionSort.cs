using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SortingExcercise.Sorts
{
    public class SelectionSort : ISortingExcercise
    {
        public int[] Sort(int[] ints)
        {
            for (int i = 0; i < ints.Length - 1; i++)
            {
                var iMin = i;
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[j] < ints[iMin])
                    {
                        iMin = j;
                    }
                    if (iMin != i)
                    {
                        var tmp = ints[i];
                        ints[i] = ints[iMin];
                        ints[iMin] = tmp;
                    }
                }
            }

            
            return ints;
        }
    }

}


//* a[0] to a[n-1] is the array to sort */
//int i,j;
//int iMin;
 
//* advance the position through the entire array */
//*   (could do j < n-1 because single element is also min element) */
//for (j = 0; j < n-1; j++) {
//    /* find the min element in the unsorted a[j .. n-1] */
 
//    /* assume the min is the first element */
//    iMin = j;
//    /* test against elements after j to find the smallest */
//    for ( i = j+1; i < n; i++) {
//        /* if this element is less, then it is the new minimum */  
//        if (a[i] < a[iMin]) {
//            /* found new minimum; remember its index */
//            iMin = i;
//        }
//    }
 
//    if(iMin != j) {
//        swap(a[j], a[iMin]);
//    }
 
//}