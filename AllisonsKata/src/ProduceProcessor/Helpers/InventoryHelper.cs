using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Core.Models;

namespace ProduceProcessor.Helpers
{
    public static class InventoryHelper
    {
        private static readonly Regex ProductRegex = new Regex(@"([\w\s]+) (-?\d*) (-?\d*)",RegexOptions.Compiled | RegexOptions.IgnoreCase);
        
        public static IEnumerable<Product> GetInventoryFromInput()
        {
            var productInventory = new List<Product>();
            
            try
            {
                var streamReader = new StreamReader("./input/inventory.txt");
                var streamReaderReadLine = streamReader.ReadLine();
                
                while (streamReaderReadLine != null)
                {
                    var productMatch = ProductRegex.Matches(streamReaderReadLine).FirstOrDefault();

                    if (productMatch == null)
                        continue;

                    productInventory.Add(Product.Create(productMatch.Groups[1].Value.Trim(), int.Parse(productMatch.Groups[2].Value), int.Parse(productMatch.Groups[3].Value)));
                    streamReaderReadLine = streamReader.ReadLine();
                }

                streamReader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }

            return productInventory;
        }
    }
}