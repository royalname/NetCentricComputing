using NetCentricComputing.Array;
using System;

namespace NetCentricComputing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            multidimensionalArray3D.Run();
            JaggedArray.Run();

            // Indexers
            IndexerDemo.Run();

            // Delegates and Events
            DelegateEventDemo.Run();
        }
    }
}