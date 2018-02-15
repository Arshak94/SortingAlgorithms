using System;
namespace SortingAlgorithms
{
    public class MergeSort
    {
        public MergeSort()
        {
        }

        public long time;

        public void Sort(int[] array){
            int[] unsortedArray = new int[array.Length];
            for (int i = 0; i < unsortedArray.Length; i++){
                unsortedArray[i] = array[i];
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            this.Sorting(unsortedArray, 0, unsortedArray.Length-1);
            time = watch.ElapsedTicks;
            for (int i = 0; i < unsortedArray.Length; i++){
                Console.Write(unsortedArray[i]+",");
            }
            Console.WriteLine();
            Console.Write("Merge Sort time" + time);
        }

        public  void Sorting(int[] array, int startIndex, int endIndex)
        {
            if(startIndex<endIndex){
                int middleIndex = (startIndex + endIndex)/2;
                Sorting(array, startIndex,middleIndex);
                Sorting(array, middleIndex+1, endIndex);
                Merge(array, startIndex, middleIndex, endIndex);
            }
        }

        static void Merge(int[] array, int lowindex, int middleIndex, int highIndex)
        {
            int n1 = middleIndex - lowindex + 1;
            int n2 = highIndex - middleIndex;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            int i;
            for (i = 0; i < n1; i++)
                leftArray[i] = array[lowindex + i];
            int j;
            for (j = 0; j < n2; j++)
                rightArray[j] = array[middleIndex + 1 + j];

            i = 0; 
            j = 0; 
            int k = lowindex; 
            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
