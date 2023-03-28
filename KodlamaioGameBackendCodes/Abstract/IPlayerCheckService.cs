using KodlamaioGameBackendCodes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameBackendCodes.Abstract
{
    public interface IPlayerCheckService
    {
        void CheckIfRealPlayer(Player player);
    }
}
