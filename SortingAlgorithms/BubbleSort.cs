using System;
namespace SortingAlgorithms
{
    public class BubbleSort
    {

        public long time;

        public BubbleSort()
        {
        }
        public int[] Sort(int[] array)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] array1 = array;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i]>array[j])
                    {
                        Swaping.swap(ref array[i], ref array[j]);  
                    }
                }
            }

            time = watch.ElapsedTicks;
            watch.Stop();
            return array1;
        }
    }
}
