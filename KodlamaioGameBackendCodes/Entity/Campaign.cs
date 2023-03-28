using KodlamaioGameBackendCodes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameBackendCodes.Entity
{
    public class Campaign : IEntitiy
    {
        public Campaign(string campaignName, float campaignPercentage)
        {
            CampaignName = campaignName;
            CampaignPercentage = campaignPercentage;
        }
        public string CampaignName { get; set; } 
        public float CampaignPercentage { get; set; }
    }
}
