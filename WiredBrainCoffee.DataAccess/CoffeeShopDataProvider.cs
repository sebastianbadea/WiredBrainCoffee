using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 10};
            yield return new CoffeeShop { Location = "Purcareni", BeansInStockInKg = 50 };
            yield return new CoffeeShop { Location = "Tatarasti de Sus", BeansInStockInKg = 100 };
        }
    }
}
