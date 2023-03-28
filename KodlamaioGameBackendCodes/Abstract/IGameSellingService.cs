using KodlamaioGameBackendCodes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameBackendCodes.Abstract
{
    public interface IGameSellingService
    {
        void SellGame(Player player, Game game, Campaign campaign);
        
    }
}
