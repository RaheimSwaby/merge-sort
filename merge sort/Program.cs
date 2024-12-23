using System.Text.Json.Serialization;

namespace merge_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, -5, -7, 4, 99 };
            Console.WriteLine("original array:" + string.Join(",", arr));

            MergeSort(arr);
            Console.WriteLine("sorted array" + string.Join(",", arr));
        }



        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1) { return; }
            int middle = arr.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                left[i] = arr[i];
            }
            for (int i = middle; i < arr.Length; i++)
            {
                right[i - middle] = arr[i];
            }
            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);
        }


        public static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }
            while (i < left.Length)
            {
                arr[k++] = left[i++];
            }
            while (j < right.Length)
            {
                arr[k++] = right[j++];
            }
        }
    }
}
