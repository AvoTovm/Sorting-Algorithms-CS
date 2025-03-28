using System;

namespace QuickSort
{
    internal class MainClass
    {
        public static void Main()
        {
            int[] arr = { 9, 3, 7, 5, 6, 2, 8 };

            Console.WriteLine("Original array " + string.Join(", ", arr));

            QuickSort.Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted Array " + string.Join(", ", arr));
        }
    }
}