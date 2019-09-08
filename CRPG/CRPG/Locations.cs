using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    class Locations
    {
        Items items = new Items();
        Player p = new Player();
        ShortCuts sC = new ShortCuts();
        Helpers h = new Helpers();
        bool Arrival = true;
        public void TownEntrance()
        {
            Console.Clear();
            if (Arrival)
            {
                sC.TB($"As the sun sets over the horizon, the skeletal silhouette of a town \nprotrudes from the horizon. \nPress Any Key to Continue...");
                Console.ReadKey();
                sC.TB($"The shadows eminating from the town continue to grow until they envelop you, \nleaving you in the evening shade. \nScanning your surroundings you don't see any other town-shaped shadows, narrowing your options considerably.");
                Console.ReadKey();
            }
        }
        void Saloon()
        {

        }
        void Shop()
        {

        }
        void Hideout()
        {

        }
    }
}
