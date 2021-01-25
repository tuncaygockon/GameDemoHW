using System;
using GameDemoHW;
using GameDemoHW.Abstract;
using GameDemoHW.Entities;
using GameDemoHW.Concrete;
using System.Collections.Generic;

namespace GameDemoHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game { GameID = 1, GameName = "Stardew Valley", UnitPrice = 24, SaleInfo = false };
            Game game2 = new Game { GameID = 2, GameName = "Starbound", UnitPrice = 20, SaleInfo = true };
            Game game3 = new Game { GameID = 3, GameName = "Rust", UnitPrice = 35, SaleInfo = false };
            Game game4 = new Game { GameID = 4, GameName = "Dragonball Figter Z", UnitPrice = 60, SaleInfo = false };
            Game game5 = new Game { GameID = 5, GameName = "Mortal Kombat 11", UnitPrice = 60, SaleInfo = true };
            Game game6 = new Game { GameID = 6, GameName = "Street Fighter V", UnitPrice = 30, SaleInfo = true };

            Game[] games = new Game[] { game1, game2, game3, game4, game5, game6 };
            List<Game> listGames = new List<Game> { game1, game2, game3, game4, game5, game6 };

            Customer customer1 = new Customer { Id = 1, Name = "Tuncay", Surname = "Göçkon", Password = "1234", BirthYear = 1997, NationalityID = "20000000001" };
            Customer customer2 = new Customer { Id = 2, Name = "Ozan", Surname = "Şengül", Password = "1235", BirthYear = 1997, NationalityID = "20000000002" };
            Customer customer3 = new Customer { Id = 3, Name = "Caner", Surname = "Atlı", Password = "1236", BirthYear = 1996, NationalityID = "20000000003" };

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            Sale sale1 = new Sale { GameName = "Starbound", Discount = 50 };
            Sale sale2 = new Sale { GameName = "Mortal Kombat 11", Discount = 50 };
            Sale sale3 = new Sale { GameName = "Street Fighter V", Discount = 50 };

            List<Sale> allSales = new List<Sale> { sale1, sale2, sale3 };

            SaleManager saleManager = new SaleManager();
            GameManager gameManager = new GameManager();
            EDevletManager eDevletManager = new EDevletManager();
            CustomerManager customerManager = new CustomerManager();

            while (true)
            {
            menu: Console.WriteLine("Choose an option: \r\n 1. Player Options \r\n 2. Games");
                string o1 = null;
                o1 = Console.ReadLine();

                switch (o1)
                {
                    case "1":
                        Console.WriteLine("Please choose an option: \r\n 1. Sign Up \r\n 2. Delete Your Account \r\n 3. Update Your Account");
                        string o2 = null;
                        o2 = Console.ReadLine();

                        switch (o2)
                        {
                            case "1":
                                Console.WriteLine("Enter your Nationality ID Number:");
                                string enteredID = null;
                                enteredID = Console.ReadLine();
                                for (int y = 0; y < customers.Length; y++)
                                {
                                    if (enteredID == customers[y].NationalityID)
                                    {
                                        eDevletManager.ValidCustomer();
                                        customerManager.SignUp(new Customer());
                                        goto menu;
                                    }
                                }
                                Console.WriteLine("Wrong Nationality ID Number.");
                                break;
                            case "2":
                                Console.WriteLine("Enter your password to continue:");
                                customerManager.Delete(Console.ReadLine());
                                break;
                            case "3":
                                customerManager.Update();
                                goto menu;
                        }
                        break;
                    case "2":
                        Console.WriteLine("All Games:");
                        gameManager.ListAll(listGames);
                        Console.WriteLine("--------------------");
                        saleManager.ShowSales(allSales);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Games on sale:");
                        gameManager.ListOnSale(listGames);
                        Console.WriteLine("\r\nEnter a game ID to continue");
                        int enteredNo = new int();
                        enteredNo = Convert.ToInt32(Console.ReadLine());
                        #region
                        for (int i = 0; i < games.Length; i++)
                        {
                            if (enteredNo == games[i].GameID)
                            {
                                Console.WriteLine("Please choose: \r\n 1. Add to cart \r\n 2. Buy now");
                                string o3 = null;
                                o3 = Console.ReadLine();
                                switch (o3)
                                {
                                    case "1":
                                        gameManager.AddToCart(game2);
                                        Console.WriteLine("WEEKLONG DEAL:");
                                        Console.WriteLine("\n" + "Rather than $" + game2.UnitPrice + "\n");
                                        saleManager.CalculateOffer(game2);

                                        goto menu;
                                    case "2":
                                        gameManager.Buy(game5);
                                        Console.WriteLine("WEEKLONG DEAL:");
                                        Console.WriteLine("\n" + "Rather than $" + game5.UnitPrice + "\n");
                                        saleManager.CalculateOffer(game5);
                                        goto menu;
                                    case "3":
                                        gameManager.Buy(game6);
                                        Console.WriteLine("WEEKLONG DEAL:");
                                        Console.WriteLine("\n" + "Rather than $" + game6.UnitPrice + "\n");
                                        saleManager.CalculateOffer(game6);
                                        goto menu;

                                }
                            }
                        }
                        Console.WriteLine("Game ID not found try again.");
                        #endregion
                        goto menu;


                    case "3":
                        customerManager.Update();
                        goto menu;



                }
            }
        }
    }
}
