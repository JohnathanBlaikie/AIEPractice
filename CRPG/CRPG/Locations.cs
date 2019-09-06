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
        void TownEntrance()
        {
            Console.Clear();
            if (Arrival)
            {
                sC.TB($"As the sun sets over the horizon, the skeletal silhouette of a town \nprotrudes from the horizon ");
            }
        }
    }
}
