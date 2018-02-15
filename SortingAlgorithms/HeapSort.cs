using System;
namespace SortingAlgorithms
{
    public class HeapSort
    {
        public HeapSort()
        {
        }

        private int heapSize;

        public long time;

        private void Sorting(int[] arr)
        {
            
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }
        private void Heapify(int[] arr, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && arr[left] > arr[index])
            {
                largest = left;
            }

            if (right <= heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swaping.swap(ref arr[index], ref arr[largest]);
                Heapify(arr, largest);
            }
        }
        public int[] Sort(int[] arr)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] unsortedArray = new int[arr.Length];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = arr[i];
            }
            Sorting(unsortedArray);
            for (int i = unsortedArray.Length - 1; i >= 0; i--)
            {
                Swaping.swap(ref unsortedArray[0],ref unsortedArray[i]);
                heapSize--;
                Heapify(unsortedArray, 0);
            }
            time = watch.ElapsedTicks;
            watch.Stop();
            return unsortedArray;
        }
    }
}
