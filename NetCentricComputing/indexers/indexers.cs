using System;

namespace NetCentricComputing
{
    class Car
    {
        private string[] cars = new string[3];

        public string this[int index]
        {
            get
            {
                return cars[index];
            }
            set
            {
                cars[index] = value;
            }
        }
    }

    class IndexerDemo
    {
        public static void Run()
        {
            Console.WriteLine("Indexers");

            Car car = new Car();

            car[0] = "Toyota";
            car[1] = "Honda";
            car[2] = "Tesla";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Car {i + 1}: {car[i]}");
            }

            Console.WriteLine();
        }
    }
}