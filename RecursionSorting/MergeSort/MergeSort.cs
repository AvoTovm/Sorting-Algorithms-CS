using System;


namespace MergeSort
{
    class MergeSort
    {
        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            int[] leftArr = new int[leftSize];
            int[] rightArr = new int[rightSize];

            for(int i = 0; i < leftSize; i++) leftArr[i] = arr[left + i];
            for(int i = 0; i < rightSize; i++) rightArr[i] = arr[mid + 1 + i];

            int leftIndex = 0, rightIndex = 0, mergedIndex = left;

            while(leftIndex < leftSize && rightIndex < rightSize)
            {
                if (leftArr[leftIndex] <= rightArr[rightIndex])
                    arr[mergedIndex++] = leftArr[leftIndex++];
                else
                    arr[mergedIndex++] = rightArr[rightIndex++];
            }

            while (leftIndex < leftSize) arr[mergedIndex++] = leftArr[leftIndex++];
            
            while(rightIndex < rightSize) arr[mergedIndex++]= rightArr[rightIndex++];
        }

        public static void MergeSortAlgo(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSortAlgo(arr, left, mid);
                MergeSortAlgo(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
