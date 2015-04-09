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
            int choice;
            Console.WriteLine("Please Select 1-Bubble Sort 2-Selection Sort 3-Insertion Sort 4-Merge Sort 5-Quick Sort");
            choice = int.Parse(Console.ReadLine());
            Sort sort;
            //Bubble Sort
            if (choice == 1)
            {
                sort = new BubbleSort();
                sort.sorting(elements);
            }

            //Selection Sort
            else if (choice == 2)
            {
                sort = new SelectionSort();
                sort.sorting(elements);
            }

            //Insertion Sort
            else if (choice == 3)
            {
                sort = new InsertionSort();
                sort.sorting(elements);
            }

            //Merge Sort
            else if (choice == 4)
            {
                sort = new MergeSort();
                sort.sorting(elements);
            }

            //Quick Sort
            else
            {
                sort = new QuickSort();
                sort.sorting(elements);
            }

            Console.ReadLine();
        }
    }
}
