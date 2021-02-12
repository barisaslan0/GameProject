using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası geldi! Fırsatları Kaçırma!");
            Console.WriteLine("Bitiş tarihi: " + campaign.CampaignEndDate);
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void UpDate(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
