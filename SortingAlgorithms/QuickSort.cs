using System;
namespace SortingAlgorithms
{
    public class QuickSort
    {
        public long time;

        public QuickSort()
        {
        }

        public int[] Sort(int[] array){
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] unsortedArray = new int[array.Length];
            for (int i = 0; i < unsortedArray.Length; i++){
                unsortedArray[i] = array[i];
            }
            int[] arr = this.Sorting(unsortedArray, 0, unsortedArray.Length - 1);
            time = watch.ElapsedTicks;
            watch.Stop();
            return arr;
        }

        public int Partition(int[] array, int lowIndex, int highIndex){

            int pivot = array[highIndex];
            int i = lowIndex-1;
            for (int j = lowIndex; j < highIndex; j++){
                if(array[j]<=pivot){
                    i++;
                    Swaping.swap(ref array[i], ref array[j]);
                }
            }
            Swaping.swap(ref array[i + 1], ref array[highIndex]);
            return i+1;
        }
        public int[] Sorting(int[] arrray, int lowIndex, int highIndex){
            if(lowIndex<highIndex){
                int partiotion = Partition(arrray, lowIndex, highIndex);
                Sorting(arrray, lowIndex, partiotion-1);
                Sorting(arrray, partiotion+1, highIndex);
            }
            return arrray;
        } 
    }
}
