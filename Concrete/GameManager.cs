using System;
using System.Collections.Generic;
using System.Text;
using GameDemoHW;
using GameDemoHW.Abstract;
using GameDemoHW.Entities;

namespace GameDemoHW.Concrete
{
    class GameManager : IGameService
    {
        public void AddToCart(Game game)
        {
            Console.WriteLine(game.GameName + " is added to your cart.");
        }

        public void Buy(Game game)
        {
            Console.WriteLine("Buy " + game.GameName + " only for $ " + game.UnitPrice + " now! ");
        }

        public void ListAll(List<Game> listGames)
        {
            foreach (var item in listGames)
            {
                Console.WriteLine("Game ID: " + item.GameID + " / " + item.GameName + " - " + "$" + item.UnitPrice);
            }
        }

        public void ListOnSale(List<Game> listGames)
        {
            for (int i = 0; i < listGames.Count; i++)
            {
                if(listGames[i].SaleInfo == true)
                {
                    Console.WriteLine("Game ID: " + listGames[i].GameID + " / " + listGames[i].GameName + " - " + "$" + listGames[i].UnitPrice);
                }
            }
        }
    }
}
