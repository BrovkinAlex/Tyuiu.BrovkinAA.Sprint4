﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrovkinAA.Sprint4.Task5.V11.Lib
{
    public class DataService : ISprint4Task5V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > 0)
                        matrix[i, j] = 1;

            return matrix;
        }
    }
}
