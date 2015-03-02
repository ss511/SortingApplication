using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new Int32[5];
            Console.WriteLine("Please Enter Array Elements:");
            for (int i = 0; i < 5; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }
            //Bubble Sort
            Sort sort = new BubbleSort();
            sort.sorting(elements);

            //Selection Sort
            sort = new SelectionSort();
            sort.sorting(elements);

            //Insertion Sort
            sort = new InsertionSort();
            sort.sorting(elements);

            //Merge Sort
            sort = new MergeSort();
            sort.sorting(elements);

            //Quick Sort
            sort = new QuickSort();
            sort.sorting(elements);

            Console.ReadLine();
        }
    }
}
