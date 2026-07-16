using NetCentricComputing.Array;
using System;
using System.Threading.Tasks;

namespace NetCentricComputing
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Array
            multidimensionalArray3D.Run();
            JaggedArray.Run();

            // Indexers
            IndexerDemo.Run();

            // Delegates and Events
            DelegateEventDemo.Run();

            // Async and Await
            await async_await.Run();
        }
    }
}