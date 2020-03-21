using System;
using System.Collections.Generic;
using System.Text;

namespace Gaus
{
    public static class Matrix
    {
        public static double[,] DivideRow(double[,] matrix, int row, double divider)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[row, i] /= divider;
            }
            return matrix;
        }

        public static double[] CutResult(double[,] matrix)
        {
            double[] result = new double[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result[i] = matrix[i, matrix.GetLength(1) - 1];
            }
            return result;
        }

        public static double[,] SubtractRows(double[,] matrix, int firstrow, int secondrow, double count)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[secondrow, i] -= matrix[firstrow, i] * count;
            }
            return matrix;
        }

        public static double[,] CreateDownOneZero(double[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix = DivideRow(matrix, row, matrix[row, row]);
                for (int i = row + 1; i < matrix.GetLength(0); i++)
                {
                    SubtractRows(matrix, row, i, matrix[i, row]);
                }
            }

            return matrix;
        }

        public static double[,] CreateUpOneZero(double[,] matrix)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int i = row - 1; i >= 0; i--)
                {
                    SubtractRows(matrix, row, i, matrix[i, row]);
                }
            }

            return matrix;
        }

        public static double[] Solve(double[,] matrix)
        {
            matrix = CreateDownOneZero(matrix);
            matrix = CreateUpOneZero(matrix);
            return CutResult(matrix);
        }
    }
}
