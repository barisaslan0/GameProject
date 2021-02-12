using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Sale(Gamer gamer,Sale sale);
        void CampaignSale(Gamer gamer, Sale sale, Campaign campaign);
    }
}
