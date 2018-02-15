using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public long time;
        public InsertionSort()
        {
        }
        public int[] Sort(int[] array){
            int[] array1 = new int[array.Length];
            for (int i = 0; i < array1.Length; i++){
                array1[i] = array[i];
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            for (int i = 0; i < array1.Length-1;i++)
            {
                int j = i + 1;
                while(j>0)
                {
                    if (array1[j-1] > array1[j])
                    {
                        Swaping.swap(ref array1[j-1], ref array1[j]);
                    }
                    j--;
                }

            }
            watch.Stop();
            this.time = watch.ElapsedTicks;
            return array1;
        } 

    }
}
