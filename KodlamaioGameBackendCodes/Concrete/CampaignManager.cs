using KodlamaioGameBackendCodes.Abstract;
using KodlamaioGameBackendCodes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameBackendCodes.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine
                ("Campaign : "+campaign.CampaignName+ " Is Now For "+ campaign.CampaignPercentage+ " Off!");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign : " + campaign.CampaignName + " Had Been Deleted");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign : " + campaign.CampaignName + " Had Been Updated");
        }
    }
}
