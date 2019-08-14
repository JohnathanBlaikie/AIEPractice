using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBrowser
{
    struct ServerInfo
    {
        public int regionID;
        public int currentPlayerCount;
        public int maxPlayers;
        public int ping;
    }
    class ServerBrowserService
    {
       
        // An array of all servers registered with the system.
        private ServerInfo[] servers = new ServerInfo[50]; 

        // A count of all servers currently registered.
        private int serverCount;

        // Registers a server with the service
        public bool registerServer(ServerInfo newServer)
        {
            if (serverCount < 49)
            {
                return false;
            }
                servers[serverCount] = newServer;
                serverCount++;
                return true;
        }

        // Copies server entries into the given array.
        // Returns the total number of servers provided to the array.
        public int getServers(ServerInfo[] dstArray)
        {
            dstArray = new ServerInfo[50];
            int svrsCopied = 0;
            int dstIndex = 0;
            for (int svrsCopied2 = 0; svrsCopied2 < serverCount; svrsCopied2++)
            {
                if (true)
                {
                    dstArray[svrsCopied2] = servers[svrsCopied2];
                    dstIndex++;
                }
            }
            return svrsCopied;
        }
    }
}
