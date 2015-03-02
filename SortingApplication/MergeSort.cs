using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class MergeSort:Sort
    {
        public void sorting(int[] arr)
        {
            partition(arr);
            int n = arr.Length;
            Console.WriteLine("\nMerge Sort:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        /*
         *Partitions the array until the array size becomes 1
         *
        */
        void partition(int[] arr)
        {
            int n = arr.Length;
            if (n < 2)
                return;
            int mid;
            mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < n; i++)
            {
                right[i-mid] = arr[i];
            }
            partition(left);
            partition(right);
            merge(left, right, arr);
        }
        /*
         *Merges the two partitioned array into one in sorted order
         * 
         */
        void merge(int[] left, int[] right, int[] arr)
        {
            int nl = left.Length;
            int nr = right.Length;
            int i, j, k;
            i = j = k = 0;
            while (i < nl && j < nr)
            {
                if (left[i] < right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < nl)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < nr)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
