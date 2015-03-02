using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class QuickSort : Sort
    {
        public void sorting(int[] arr)
        {
            int n = arr.Length;
            QuickSortRun(arr, 0, n-1);
            Console.WriteLine("\nQuick Sort:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        void QuickSortRun(int[] arr, int start, int end)
        {
            int pivot; 
            if (start >= end)
            {
                return;
            }
            pivot = Partition(arr, start, end);
            QuickSortRun(arr, start, pivot - 1);
            QuickSortRun(arr, pivot+1, end);
        }
        int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int pIndex = start;
            int temp;
            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex++;
                }
            }
            temp = arr[pIndex];
            arr[pIndex] = arr[end];
            arr[end] = temp;
            return pIndex;
        }

    }
}
