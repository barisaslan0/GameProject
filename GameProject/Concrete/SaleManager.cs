using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void CampaignSale(Gamer gamer, Sale sale, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ", " + sale.GameName + " oyununu satın aldınız.");
            Console.WriteLine(campaign.CampaignName + " kampanyası dahilinde 70TL kupon kazandınız.");
        }

        public void Sale(Gamer gamer, Sale sale)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + ", " + sale.GameName + " oyununu satın aldnız.");
        }
    }
}
