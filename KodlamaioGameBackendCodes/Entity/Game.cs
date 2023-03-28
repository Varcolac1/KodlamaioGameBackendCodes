using KodlamaioGameBackendCodes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameBackendCodes.Entity
{
    public class Game : IEntitiy
    {
        public Game(string gameName, float gamePrice)
        {
            GameName = gameName;
            GamePrice = gamePrice;
        }
        public string GameName { get; set; }
        public float GamePrice { get; set; }
    }
}
