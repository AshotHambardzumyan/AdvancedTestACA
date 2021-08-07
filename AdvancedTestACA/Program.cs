using System;

namespace AdvancedTestACA
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 38;
            Console.WriteLine($"Input Number is: {inputNum}");

            int num = FindSum(inputNum);

            Console.WriteLine($"Result is: {num}");
        }

        public static int FindSum(int num)
        {
            int sum = 0;
            int count = 0;

            while (num >= 10)
            {
                sum += num % 10;
                num = num / 10;

                if (num < 10)
                {
                    count++;
                    sum += num;
                    Console.WriteLine($"Sum {count}: {sum}");
                    num = sum;
                    sum = 0;
                }
            }
            Console.WriteLine($"\nCount: {count}");

            return num;
        }
    }
}