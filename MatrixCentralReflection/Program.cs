using System;

namespace MatrixCentralReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Print(matrix);
            Console.WriteLine();

            Print(FindCentralReflection(matrix));

            Console.WriteLine();
            Print(FindCentralReflection2(matrix));

        }

        public static int[,] FindCentralReflection(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int[,] newMatrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    newMatrix[i, j] = matrix[row - i - 1, col - j - 1];
                }
            }

            return newMatrix;
        }

        public static int[,] FindCentralReflection2(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int[,] newMatrix = new int[row, col];

            if (row == col)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        newMatrix[i, j] = matrix[row - j - 1, col - 1 - i];
                    }
                }
                return newMatrix;
            }
            return null;
        }

        public static void Print(int[,] matrix)
        {
            if (matrix != null)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}