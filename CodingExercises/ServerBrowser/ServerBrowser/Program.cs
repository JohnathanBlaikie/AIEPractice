using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBrowser
{
    class Program
    {
        public static void Main(string[] args)
        {
            ServerBrowserService sbs = new ServerBrowserService();
            ServerInfo s1;
            s1.ping = 1;
            s1.currentPlayerCount = 2;
            s1.regionID = 1;
            s1.maxPlayers = 4;
            sbs.registerServer(s1);

            s1.ping = 5;
            s1.currentPlayerCount = 2;
            s1.regionID = 3;
            s1.maxPlayers = 10;
            sbs.registerServer(s1);

            s1.ping = 10;
            s1.currentPlayerCount = 10;
            s1.regionID = 3;
            s1.maxPlayers = 12;
            sbs.registerServer(s1);

            s1.ping = 8;
            s1.currentPlayerCount = 10;
            s1.regionID = 3;
            s1.maxPlayers = 64;
            sbs.registerServer(s1);

            ServerInfo[] tmpOp = new ServerInfo[0];
            int numberSvrs = sbs.getServers(ref tmpOp);

            int numberSvrs2 = sbs.getServers(ref tmp0p, 10);
        }

    }
   
}
