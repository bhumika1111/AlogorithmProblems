using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithamProgram
{
    /// <summary>
    ///   Here We Are Checking Insertion Sorting.
    /// </summary>
    class InsertionSort
    {
        public void CheckSorting()
        {
            int[] arr = { 23, 9, 85, 12 };

            int n = 4, i, j, val, flag;

            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                        flag = 1;
                }
            }
            Console.WriteLine("Sorted Array :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
