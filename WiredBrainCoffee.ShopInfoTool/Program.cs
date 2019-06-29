using System;
using System.Linq;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'help' to list the coffee shops or 'quit' to leave the program! Then write the name of the location");

            var provider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();

                if (string.Equals(line, "quit", StringComparison.InvariantCultureIgnoreCase)) break;

                var coffeeShops = provider.LoadCoffeeShops();

                if (string.Equals(line, "help"))
                {
                    Console.WriteLine("> Available coffee shops");

                    foreach (var shop in coffeeShops)
                    {
                        Console.WriteLine($"> {shop.Location}");
                    }
                }
                else
                {
                    var availableShops = coffeeShops.Where(cs => cs.Location.ToLower().StartsWith(line.ToLower()));

                    var availableShopsCount = availableShops.Count();

                    if (availableShopsCount == 0)
                    {
                        Console.WriteLine($"> No coffee shops found for {line}");
                    }
                    else
                    { 
                        if (availableShopsCount > 1)
                        {
                            Console.WriteLine($"> Multiple coffees shops available for the search criteria");

                            foreach (var availableShop in availableShops)
                            {
                                Console.WriteLine(availableShop.Location);
                            }
                        }
                        else
                        {
                            var availableShop = availableShops.Single();
                            Console.WriteLine($"> {availableShop.Location} - {availableShop.BeansInStockInKg}");
                        }
                    }
                }
            }

        }
    }
}
