using System;

namespace MergeSort
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Original Array ");
            MergeSort.PrintArray(arr);

            MergeSort.MergeSortAlgo(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted Array ");
            MergeSort.PrintArray(arr);
        }
    }
}
