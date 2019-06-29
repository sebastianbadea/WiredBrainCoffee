using System;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'help' to list the coffee shops!");

            var provider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();

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
