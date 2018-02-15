using System;
namespace SortingAlgorithms
{
    public class Swaping
    {
        public Swaping()
        {
        }
        public static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
