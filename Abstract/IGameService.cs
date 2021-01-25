using GameDemoHW.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoHW.Abstract
{
    interface IGameService
    {
        void AddToCart(Game game);
        void Buy(Game game);
        void ListAll(List<Game> listGames);
        void ListOnSale(List<Game> listGames);

    }
}
