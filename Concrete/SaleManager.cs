using System;
using System.Collections.Generic;
using System.Text;
using GameDemoHW.Abstract;
using GameDemoHW.Entities;

namespace GameDemoHW.Concrete
{
    class SaleManager
    {
        public void ShowSales(List<Sale> allSales)
        {
            Console.WriteLine("WEEKLONG DEALS");

            foreach (var item in allSales)
            {
                Console.WriteLine(item.GameName + " IS NOW " + item.Discount + "% OFF  ");
            }
        }
        public void CalculateOffer(Game game)
        {
            game.UnitPrice -= game.UnitPrice * (0.50);
            Console.WriteLine("Buy for only $ " + game.UnitPrice);
        }
    }
}
