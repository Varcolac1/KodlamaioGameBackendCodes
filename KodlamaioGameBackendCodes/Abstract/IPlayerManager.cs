using KodlamaioGameBackendCodes.Entity;

namespace KodlamaioGameBackendCodes.Abstract
{
    public interface IPlayerManager
    {
        void SignUp(Player player);
        void UpdateInfo(Player player);
        void DeleteAccount(Player player);
    }
}