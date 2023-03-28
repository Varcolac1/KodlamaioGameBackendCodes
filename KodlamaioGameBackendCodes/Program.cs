using KodlamaioGameBackendCodes.Abstract;
using KodlamaioGameBackendCodes.Concrete;
using KodlamaioGameBackendCodes.Entity;

CampaignManager campaignManager = new CampaignManager();
GameSellingManager gameSellingManager = new GameSellingManager();
PlayerManager playerManager = new PlayerManager();
Player player = new Player("1", "Alper", "Ekici", new DateTime(2003,3,31));
Game game = new Game("God Of War", 100);
Campaign campaign = new Campaign("God Of War on Sale!", 30);

playerManager.SignUp(player);
playerManager.UpdateInfo(player);
playerManager.DeleteAccount(player);
playerManager.CheckIfRealPlayer(player);

Console.WriteLine("--------------------");

gameSellingManager.SellGame(player, game, campaign);

Console.WriteLine("--------------------");

campaignManager.AddCampaign(campaign);
campaignManager.UpdateCampaign(campaign);
campaignManager.DeleteCampaign(campaign);

