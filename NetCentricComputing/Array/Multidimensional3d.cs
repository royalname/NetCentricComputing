using System;

namespace NetCentricComputing.Array
{
    internal class multidimensionalArray3D
    {
        public static void Run()
        {
            int[,,] numbers =
            {
                {
                    {1, 2, 3},
                    {4, 5, 6}
                },
                {
                    {7, 8, 9},
                    {10, 11, 12}
                }
            };

            Console.WriteLine("3D Multidimensional Array:");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine($"Layer {i}");

                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.GetLength(2); k++)
                    {
                        Console.Write(numbers[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}