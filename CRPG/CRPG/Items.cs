﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CRPG
{
    class Items
    {
        public string name;
        public int price;
        public int HealthRegen;
        public int AmmoRefill;
    }
    class Weapons
    {
        public static List<Weapons> WeaponCheck = new List<Weapons>();
        public static List<Weapons> WeaponsOwned = new List<Weapons>();
        public static List<Weapons> PreviousSave = new List<Weapons>();
        public string name;
        public int price, bDamage, StrMod, DexMod, truDamage, maxRange, ammoPerShot, ammoInMag, cRam;
        public bool ownedByPlayer;

        //Checks the master list of weapons and writes out their information.
        public void ArsenalListing()
        {
            int placeholder;
            
            using (StreamReader sr = new StreamReader("WeaponStats1.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] Values = line.Split(',');
                    Weapons tmpWeapon = new Weapons();
                    tmpWeapon.name = Values[0];
                    tmpWeapon.price = int.Parse(Values[1]);
                    tmpWeapon.maxRange = int.Parse(Values[2]);
                    tmpWeapon.bDamage = int.Parse(Values[3]);
                    tmpWeapon.StrMod = int.Parse(Values[4]);
                    tmpWeapon.DexMod = int.Parse(Values[5]);
                    tmpWeapon.ammoPerShot = int.Parse(Values[7]);
                    tmpWeapon.ammoInMag = int.Parse(Values[8]);
                    tmpWeapon.ownedByPlayer = bool.Parse(Values[9]);
                    WeaponCheck.Add(tmpWeapon);
                }
                sr.Close();
            }
            foreach (Weapons it in WeaponCheck)
            {
                placeholder = it.bDamage + (it.DexMod * Program.p.Dex) + (it.StrMod * Program.p.Str);
                Console.WriteLine($"Name: {it.name}\nPrice: {it.price}\nRange: {it.maxRange}\nDamage: {placeholder}\nPlayer-Owned: {it.ownedByPlayer}");
            }
        }

        //Functionaly the same as ArsenalListing, although this doesn't print out the info. 
        //Used at the start of the script to spawn all the weapons.
        public void ArsenalInstantiation()
        {
            using (StreamReader sr = new StreamReader("WeaponStats1.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] Values = line.Split(',');
                    Weapons tmpWeapon = new Weapons();
                    tmpWeapon.name = Values[0];
                    tmpWeapon.price = int.Parse(Values[1]);
                    tmpWeapon.maxRange = int.Parse(Values[2]);
                    tmpWeapon.bDamage = int.Parse(Values[3]);
                    tmpWeapon.StrMod = int.Parse(Values[4]);
                    tmpWeapon.DexMod = int.Parse(Values[5]);
                    tmpWeapon.ammoPerShot = int.Parse(Values[7]);
                    tmpWeapon.ammoInMag = int.Parse(Values[8]);
                    tmpWeapon.ownedByPlayer = bool.Parse(Values[9]);
                    WeaponCheck.Add(tmpWeapon);
                }
                sr.Close();
            }
            
        }

        //Similarly to the arsenal voids, this checks PlayerInv.csv for weapons. 
        //If it finds any, they are added to the players current inventory.
        public void InventoryInstantiation()
        {
            using (StreamReader sr = new StreamReader("PlayerInv.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] Values = line.Split(',');
                    Weapons tmpWeapon = new Weapons();
                    tmpWeapon.name = Values[0];
                    tmpWeapon.price = int.Parse(Values[1]);
                    tmpWeapon.maxRange = int.Parse(Values[2]);
                    tmpWeapon.bDamage = int.Parse(Values[3]);
                    tmpWeapon.StrMod = int.Parse(Values[4]);
                    tmpWeapon.DexMod = int.Parse(Values[5]);
                    tmpWeapon.ammoPerShot = int.Parse(Values[7]);
                    tmpWeapon.ammoInMag = int.Parse(Values[8]);
                    tmpWeapon.ownedByPlayer = bool.Parse(Values[9]);
                    WeaponsOwned.Add(tmpWeapon);
                }
                sr.Close();
            }
        }

        //The same as the previous, except it sends it to a list that is displayed as the previous 
        //inventory, rather than the current one.
        public void PreviousSaveCheck()
        {
            using (StreamReader sr = new StreamReader("PlayerInv.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] Values = line.Split(',');
                    Weapons tmpWeapon = new Weapons();
                    tmpWeapon.name = Values[0];
                    tmpWeapon.price = int.Parse(Values[1]);
                    tmpWeapon.maxRange = int.Parse(Values[2]);
                    tmpWeapon.bDamage = int.Parse(Values[3]);
                    tmpWeapon.StrMod = int.Parse(Values[4]);
                    tmpWeapon.DexMod = int.Parse(Values[5]);
                    tmpWeapon.ammoPerShot = int.Parse(Values[7]);
                    tmpWeapon.ammoInMag = int.Parse(Values[8]);
                    tmpWeapon.ownedByPlayer = bool.Parse(Values[9]);
                    PreviousSave.Add(tmpWeapon);
                }
                sr.Close();
            }
        }
        
        //WeaponList is an example of how I was originally planning on hard-coding each of the guns
        //in the game. 
        void WeaponList()
        {
            Weapons[] Armory = new Weapons[3];
            Weapons weapons = new Weapons();
            weapons.name = "Repeater Rifle";
            weapons.price = 100;
            weapons.bDamage = 10;
            weapons.StrMod = 0;
            weapons.DexMod = 3;
            //weapons.truDamage = bDamage + (StrMod*p.Str) + (DexMod*p.Dex);
            weapons.maxRange = 100;
            weapons.ammoPerShot = 1;
            weapons.ammoInMag = 8;
            Armory[0] = weapons;

            weapons.name = "Shotgun";
            weapons.price = 100;
            weapons.bDamage = 20;
            weapons.StrMod = 4;
            weapons.DexMod = 0;
            weapons.truDamage = bDamage + StrMod + DexMod;
            weapons.maxRange = 20;
            weapons.ammoPerShot = 2;
            weapons.ammoInMag = 2;
            Armory[1] = weapons;

            weapons.name = "Six-Shooter";
            weapons.price = 75;
            weapons.bDamage = 7;
            weapons.StrMod = 2;
            weapons.DexMod = 2;
            weapons.truDamage = bDamage + StrMod + DexMod;
            weapons.maxRange = 50;
            weapons.ammoPerShot = 1;
            weapons.ammoInMag = 6;
            Armory[2] = weapons;

            weapons.name = "PKD .223";
            weapons.price = 750;
            weapons.bDamage = 10;
            weapons.StrMod = 5;
            weapons.DexMod = 6;
            weapons.truDamage = bDamage + StrMod + DexMod;
            weapons.maxRange = 50;
            weapons.ammoPerShot = 1;
            weapons.ammoInMag = 6;
            Armory[3] = weapons;
        }
    }
    
}
