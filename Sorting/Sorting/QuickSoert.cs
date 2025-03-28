using System;

namespace QuickSort
{
    class QuickSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            QuickSortHelper(arr, 0, arr.Length - 1);
        }

        private static void QuickSortHelper(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSortHelper(arr, left, pivotIndex - 1);
                QuickSortHelper(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

}
