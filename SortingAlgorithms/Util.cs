using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public class Util
    {
        public Util()
        {
        }
        public static int[] SwithCase(int[] array,int current, int intTemp)
        {
            int[] array1 = new int[0];
            switch (current)
            {
                case 1:
                    InsertionSort insertionSort = new InsertionSort();
                    array1 = insertionSort.Sort(array);
                    foreach (int inchvorban in array1)
                    {
                        Console.Write(inchvorban + ",");

                    }
                    Console.WriteLine();
                    Console.WriteLine("Insertion Sort time"+insertionSort.time);
                    break;
                case 2:
                    BubbleSort bubbleSort = new BubbleSort();
                    array1 = bubbleSort.Sort(array);
                    foreach (int inchvorban in array1)
                    {
                        Console.Write(inchvorban + ",");

                    }
                    Console.WriteLine();
                    Console.WriteLine("Bubble Sort time" + bubbleSort.time);
                    break;
                case 3:
                    QuickSort quickSort = new QuickSort();
                    array1 = quickSort.Sort(array);
                    foreach (int inchvorban in array1)
                    {
                        Console.Write(inchvorban + ",");

                    }
                    Console.WriteLine();
                    Console.WriteLine("Quick Sort time" + quickSort.time);
                    break;
                case 4:
                    
                    HeapSort heapSort = new HeapSort();
                    array1 = heapSort.Sort(array);
                    foreach (int inchvorban in array1)
                    {
                        Console.Write(inchvorban + ",");

                    }
                    Console.WriteLine();
                    Console.WriteLine("Heap Sort time" + heapSort.time);
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.Sort(array);
                    break;
                default:
                    break;

            }
            return array1;
        }
        public static void PrintInfo()
        {
            Console.WriteLine("1. Insertion sort");
            Console.WriteLine("2. Bubble sort");
            Console.WriteLine("3. Quick sort");
            Console.WriteLine("4. Heap sort");
            Console.WriteLine("5. Merge sort");
            Console.WriteLine("6. All");
        }
    }
}
