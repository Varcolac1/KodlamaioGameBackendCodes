using KodlamaioGameBackendCodes.Abstract;
using KodlamaioGameBackendCodes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameBackendCodes.Concrete
{
    public class GameSellingManager : IGameSellingService
    {
        public void SellGame(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine
                ("Player : " + player.FirstName + " Had Bougth The Game "+ game.GameName+" For "+ 
                (game.GamePrice - (game.GamePrice * (campaign.CampaignPercentage / 100) ) ) );
        }

    }
}
