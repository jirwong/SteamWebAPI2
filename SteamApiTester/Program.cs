using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamWebAPI2;
using SteamWebAPI2.Models;
using SteamWebAPI2.Interfaces;
using Steam.Models;
using Steam.Models.SteamCommunity;

namespace SteamApiTester
{
    class Program
    {
        static void Main(string[] args)
        {

            SteamBot sb = new SteamBot();

            sb.RunBot();

            Console.ReadLine();
        }
    }

    class SteamBot
    {
        public SteamBot()
        {


        }

        public async void RunBot()
        {
            long steamId = 76561197971804071; // Me

            //string appId = "427520"; // 436090
            string appId = "440";

            string webApiKey = "A4FBB92C6423E84B3F31F5D441BECB6C";

            var steamUser = new SteamUser(webApiKey);
            var playerService = new PlayerService(webApiKey);

            OwnedGamesResultModel obj = await playerService.GetOwnedGamesAsync(steamId, true, true, null);

            string s = "";

        }

    }
}
