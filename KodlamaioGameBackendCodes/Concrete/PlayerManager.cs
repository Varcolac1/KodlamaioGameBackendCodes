using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaioGameBackendCodes.Abstract;
using KodlamaioGameBackendCodes.Entity;

namespace KodlamaioGameBackendCodes.Concrete
{
    public class PlayerManager :IPlayerManager, IPlayerCheckService
    {
        public void SignUp(Player player)
        {
            Console.WriteLine("Player : "+ player.FirstName +" Signed Up");
        }

        public void UpdateInfo(Player player)
        {
            Console.WriteLine("Player : " + player.FirstName + "'s Informations Had Been Updated");
        }
        public void DeleteAccount(Player player)
        {
            Console.WriteLine("Player : " + player.FirstName + "'s Account Had Been Deleted");
        }

        public void CheckIfRealPlayer(Player player)
        {
            Console.WriteLine(player.FirstName+" Has Been Verified");
        }
    }
}
