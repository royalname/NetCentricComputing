using System;
using System.Threading.Tasks;

namespace NetCentricComputing
{
    class async_await
    {
        public static async Task Run()
        {
            Console.WriteLine("Async and Await");

            Task<string> processTask = Process();

            // Work done while Process() is executing
            Console.WriteLine("Processing..");

            // Wait for Process() to finish
            string result = await processTask;

            Console.WriteLine(result);
            Console.WriteLine();
        }

        public static async Task<string> Process()
        {
            await Task.Delay(3000); // 3-second delay

            return "Process Completed";
        }
    }
}