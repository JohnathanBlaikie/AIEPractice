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
        ShortCuts sC = new ShortCuts();
        Helpers h = new Helpers();
        Weapons w = new Weapons();
        //int shotgunPurchase = 0;
        public void TownEntrance()
        {
            sC.TB($"As the sun sets over the horizon, the skeletal silhouette of a town \nprotrudes from the horizon. \nPress Any Key to Continue...");
            Console.ReadKey();
            Console.Clear();
            sC.TB($"The shadows eminating from the town stretch across the desert until they envelop you in evening shade. \nScanning your surroundings you don't see any other town-shaped shadows, narrowing your options for lodging considerably.");
            Console.ReadKey();
            Console.Clear();
            sC.TB("As you ride towards town, you feel an aura of unwelcoming emotions \neminating from the locals.");
            Console.ReadKey();
            Console.Clear();
            sC.TB($"Pressing onwards, you begin to make out the sign hung above the entrance...\nPress [R] to roll for perception, or press enter to skip. \nCurrent Perception: [{Program.p.Per}/10]");
            char temp = sC.RK(' ');
            if (temp == 'r')
            {
                if (h.R2H(0) + Program.p.Per >= 10)
                {
                    sC.TB("Check Success! \nThe sign reads: \"Welcome to Las Lamitas\", although the plaque is perforated with bullet holes.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    sC.TB("Check Failed.\nWhatever, it must not be *that* important.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            Console.Clear();
        }
        public void TownSquare()
        {
            sC.TB("You make your way to the center of town, on your left is an establishment\nnamed the Sasaparilla Saloon. On your right is a store ");
            sC.TB("");
        }
        void Saloon()
        {

        }
        public void Shop()
        {
            sC.TB($"\"Welcome to Mom & Pop's Firearm Shoppe!\"\nSays the bespectacled man behind the counter.");
            foreach(Weapons w in Weapons.WeaponCheck)
            {
                Console.WriteLine($"Name: {w.name}\nDamage: {w.bDamage}\nRange: {w.maxRange}\nPrice: {w.price}\n");
            }

            string test = sC.WRL($"Your Gold: {Program.p.Gold}\nChoose a weapon to purchase.");
            if (test == "s")
            {
                //gives player shotgun
                foreach (Weapons wep in Weapons.WeaponCheck)
                {
                    if (wep.name == "Double-Barrel Shotgun")
                    {
                        if (Program.p.Gold >= wep.price)
                        {
                            wep.ownedByPlayer = true;
                            Weapons.WeaponsOwned.Add(wep);
                            Program.p.Gold -= wep.price;
                            //wep.ownedByPlayer = true;
                        }
                        else { Console.WriteLine($"Sorry, but you don't have enough for this piece. \nYou need {wep.price - Program.p.Gold} more to walk off with this.s"); }
                    }
                }
            }
            else if (test == "r")
            {
                //gives player rifle
                foreach(Weapons wep in Weapons.WeaponCheck)
                if (wep.name == "Repeater Rifle")
                {
                    if (Program.p.Gold >= wep.price)
                    {
                        wep.ownedByPlayer = true;
                        Weapons.WeaponsOwned.Add(wep);
                        Program.p.Gold -= wep.price;
                        //wep.ownedByPlayer = true;
                    }
                    else { Console.WriteLine($"Sorry, but you don't have enough for this piece. \nYou need {wep.price - Program.p.Gold} more to walk off with this.s"); }
                }
            }
        }
        void Hideout()
        {

        }
    }
}
