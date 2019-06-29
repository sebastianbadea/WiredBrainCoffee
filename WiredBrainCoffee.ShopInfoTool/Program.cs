using System;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'help' to list the coffee shops or 'quit' to leave the program! MTF");

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
            }

        }
    }
}
