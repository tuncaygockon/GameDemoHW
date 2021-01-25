using GameDemoHW.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoHW.Abstract
{
    interface SaleService
    {
        void ListSales(List<Sale> allSales);
        void CalculateSale(Game game);
    }
}
