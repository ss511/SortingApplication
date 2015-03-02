using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class BubbleSort : Sort
    {
        public void sorting(int[] arr)
        {
            int swap;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }
            Console.WriteLine("Bubble Sort:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+"\t");
            }
        }
    }
}
