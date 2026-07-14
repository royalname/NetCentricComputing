using System;

namespace NetCentricComputing.Array
{
    internal class JaggedArray
    {
        public static void Run()
        {
            int[][] jaggedMatrix = new int[3][]
            {
                new int[3] {10, 20, 30},
                new int[4] {40, 50, 60, 70},
                new int[5] {80, 90, 100, 110, 120}
            };

            Console.WriteLine("Jagged Array:");

            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                Console.Write($"Row {i}: ");

                for (int j = 0; j < jaggedMatrix[i].Length; j++)
                {
                    Console.Write(jaggedMatrix[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}