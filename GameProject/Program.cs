using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                TC = "1234567890",
                FirstName = "BARIŞ",
                LastName = "ASLAN",
                BirthYear = "2000"
            };

            Game game1 = new Game
            {
                GameName = "Red Dead Redemption 2",
                GamePrice = 300
            };
            Game game2 = new Game
            {
                GameName = "CyberPunk 2077",
                GamePrice = 200
            };
            Game game3 = new Game
            {
                GameName = "The Last Of Us Part2",
                GamePrice = 150
            };

            Campaign campaign70 = new Campaign
            {
                CampaignId = 1,
                CampaignName = "200TL Üzeri 70TL Kupon",
                CampaignEndDate = "02.03.2021"
            };

            Sale sale = new Sale
            {
                Gamer = gamer.FirstName + gamer.LastName,
                GameName = game2.GameName,
                GamePrice = game2.GamePrice
            };



            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);
            gamerManager.Add(gamer);
            if (userValidationManager.Validate(gamer) == true)
            {
                Console.WriteLine("");

                Console.WriteLine("OYUNLAR");
                GameManager gameManager = new GameManager();
                gameManager.Add(game1);
                gameManager.Add(game2);
                gameManager.Add(game3);

                Console.WriteLine("");

                Console.WriteLine("KAMPANYALAR");
                CampaignManager campaignManager = new CampaignManager();
                campaignManager.Add(campaign70);

                Console.WriteLine("");

                Console.WriteLine("SON İŞLEMLER");
                SaleManager saleManager = new SaleManager();
                if (sale.GamePrice >= 200)
                {
                    saleManager.CampaignSale(gamer, sale, campaign70);
                }
                else
                {
                    saleManager.Sale(gamer, sale);
                }
            }
        }
    }
}
