using System;

namespace DataStructures.Arrays.MultiDimensionalArrays
{
    class MultiDimensionalArrays_Program
    {
        static void Main(string[] args)
        {
            #region Two Dimensional Array

            //Two dimensional array
            int[,] array2D = new int[,] { };

            int[,] array2DInitialized = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //Two dimensional array with dimension specified
            int[,] array2DWithDimensions = new int[3, 3];

            int[,] array2DWithDimensionsInitialized = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            #endregion

            #region Three Dimensional Array

            //Three dimensional array
            int[,,] array3D = new int[,,] { };

            int[,,] array3DInitialized = new int[,,]
                                             {
                                                 {
                                                     { 1, 2 }, { 3, 4 }
                                                 },
                                                 {
                                                     { 5, 6 }, { 7, 8 }
                                                 }
                                             };

            //Three dimensional array with dimension specified
            int[,,] array3DWithDimensions = new int[2, 3, 4];

            int[,,] array3DWithDimensionsInitialized = new int[2, 3, 4]
                                                           {
                                                               {
                                                                   { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }
                                                               },
                                                               {
                                                                   { 4, 5, 6, 7 }, { 5, 6, 7, 8 }, { 6, 7, 8, 9 }
                                                               }
                                                           };

            #endregion

            PrintArray2D(array2DWithDimensionsInitialized);
            PrintArray3D(array3DWithDimensionsInitialized);
        }

        private static void PrintArray2D(int[,] array2D)
        {
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.WriteLine($"Array[{i},{j}] = {array2D[i, j]}");
                }
            }
        }

        private static void PrintArray3D(int[,,] array3D)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.WriteLine($"Array[{i},{j},{k}] = {array3D[i, j, k]}");
                    }
                }
            }
        }
    }
}
