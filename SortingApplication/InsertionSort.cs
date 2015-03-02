using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class InsertionSort : Sort
    {
        public void sorting(int[] arr)
        {
            int swap;
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                swap = arr[i];
                int j = i - 1;
                while(swap<arr[j] && j>=0)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j + 1] = swap;
            }
            Console.WriteLine("\nInsertion Sort:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }

        }
    }
}
