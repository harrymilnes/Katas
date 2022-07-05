using System;
using ProduceProcessor.Helpers;

namespace ProduceProcessor
{
    internal static class Program
    {
        private static void Main()
        {
            var inventory = InventoryHelper.GetInventoryFromInput();

            foreach (var product in inventory)
            {
                product.Rule.Process();
                Console.WriteLine(product.Output());
            }
            
            Console.ReadLine();
        }
    }
}