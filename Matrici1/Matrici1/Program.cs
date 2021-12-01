﻿using System;

namespace Matrici1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] matrix1 = ReadMatrix();
            PrintMatrix(matrix1);
            Identice(matrix1);

        }
        public static class ConsoleHelper
        {
            public static int ReadNumber(string label, int maxTries, int defaultValue)
            {
                int currentTry = 0;
                do
                {
                    Console.Write(label);
                    string valueAsString = Console.ReadLine();
                    int valueAsNumber;
                    bool isNumber = int.TryParse(valueAsString, out valueAsNumber);

                    if (isNumber)
                    {
                        return valueAsNumber;
                    }

                    currentTry++;
                    Console.WriteLine($"The value '{valueAsString}' doen't represent a valid number, please try again ...");
                }
                while (currentTry < maxTries);

                return defaultValue;
            }
        }
        public static int[,] ReadMatrix()
        {
            // citesc nr de linii
            int rowsCount = ConsoleHelper.ReadNumber("Nr de linii=", 3, 0);

            // citesc nr de coloane
            int colsCount = ConsoleHelper.ReadNumber("Nr de coloane=", 3, 0);

            int[,] matrix = new int[rowsCount, colsCount];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int element = ConsoleHelper.ReadNumber($"Element[{row},{col}]=", 3, 0);
                    matrix[row, col] = element;
                }
            }

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            if (matrix is null)
            {
                Console.WriteLine("Matrix is null");
                return;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col],6}");
                }

                Console.WriteLine();
            }
        }
        public static void Identice(int[,] matrix)
        { 
            int ok = 0;//nu este identica
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row != col)
                    {
                        if (matrix[row, col] == 0)
                            ok = 1;
                    }
                    else
                        if (row == col)
                    {
                        if (matrix[row, col] != 1)
                            ok = 0;
                    }


                }
               

               

                Console.WriteLine();
               // return ok ;
            }
            if (ok == 0)
                Console.WriteLine("matricea nu este identica");
            else
                Console.WriteLine("matricea este identica");
        }
    }
}