﻿using System;
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
        Weapons w = new Weapons();
        //int shotgunPurchase = 0;
        public void TownEntrance()
        {
            sC.TB($"As the sun sets over the horizon, the skeletal silhouette of a town \nprotrudes from the horizon. \nPress Any Key to Continue...");
            Console.ReadKey();
            Console.Clear();
            sC.TB($"The shadows eminating from the town stretch across the desert until they envelop you in evening shade. \nScanning your surroundings you don't see any other town-shaped shadows, narrowing your options for lodging considerably.");
            Console.ReadKey();
            sC.TB("As you ride into town, you feel the aura of unwelcomeness\neminating from the locals.");
            sC.RK(' ');
            sC.TB("Pressing onwards, you begin to make out the ");
            Console.Clear();
        }
        public void TownSquare()
        {
            //bool Arrival;
            
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

            string test = sC.WRL($"Your Gold:{p.Gold}\nChoose a weapon to purchase.");
            if (test == "s")
            {
                //gives player shotgun
                foreach (Weapons wep in Weapons.WeaponCheck)
                {
                    if (wep.name == "Double-Barrel Shotgun")
                    {
                        if (p.Gold >= wep.price)
                        {
                            wep.ownedByPlayer = true;
                            Weapons.WeaponsOwned.Add(wep);

                            //wep.ownedByPlayer = true;
                        }
                        else { Console.WriteLine($"Sorry, but you don't have enough for this piece. \nYou need {wep.price - p.Gold} more to walk off with this.s"); }
                    }
                }
            }
            else if (test == "r")
            {
                //gives player rifle
            }
        }
        void Hideout()
        {

        }
    }
}
