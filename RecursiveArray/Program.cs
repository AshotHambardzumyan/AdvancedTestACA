using System;

namespace AdvancedTestACA
{
    class Program
    {
        /// <summary>
        /// Find the smallest element.
        /// </summary>
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 9, 7, 1, 8, 3, 4 };

            Console.WriteLine($"RecursiveMethod1: {RecursiveMethod1(array, array.Length)}");

            int min = RecursiveMethod2(array, array[0]);

            Console.WriteLine($"RecursiveMethod2: {min}");
        }

        public static int RecursiveMethod1(int[] arr, int length)
        {
            if (length == 1)
            {
                return arr[0];
            }

            return Math.Min(arr[length - 1], RecursiveMethod1(arr, length - 1));
        }


        public static int RecursiveMethod2(int[] arr, int min, int count = 1)
        {
            if (arr[count] < min)
            {
                min = arr[count];
            }
            count = count + 1;

            if (count == arr.Length)
            {
                return min;
            }

            return RecursiveMethod2(arr, min, count);
        }
    }
}