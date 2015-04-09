using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SelectionSort : Sort
    {
        public void sorting(int[] arr)
        {
            int swap;
            int position;
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                position = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[position] > arr[j])
                        position = j;   
                }
                if (position != i)
                {
                    swap = arr[i];
                    arr[i] = arr[position];
                    arr[position] = swap;
                }
            }
            Console.WriteLine("\nSelection Sort:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
    }
}
