using System;

namespace AdvancedTestACA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 8, 9, 7, 6, 1 };
            int k = 4;

            Console.WriteLine($"Max Average is: {FindLargestAverage(array, k)}");
        }

        public static int FindLargestAverage(int[] arr, int k)
        {
            int average = 0;
            int maxAverage = 0;

            if (arr.Length == k)
            {
                for (int i = 0; i < k; i++)
                {
                    average += arr[i];
                }
                return average;
            }
            int count = arr.Length - k + 1;

            for (int i = 0; i < count; i++)
            {
                for (int j = i; j < k; j++)
                {
                    average += arr[j];
                }

                if (average > maxAverage)
                {
                    maxAverage = average;
                }
                average = 0;
                k++;
            }

            return maxAverage;
        }
    }
}