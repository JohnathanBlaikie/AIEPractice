using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Player p = new Player();
        public string name;
        public int price;
        public int bDamage;
        public int StrMod;
        public int DexMod = p.de;
        public int truDamage;
        public int maxRange;
        public int ammoPerShot;
        public int ammoInMag;

        void WeaponList()
        {
            Weapons[] Arsenal = new Weapons[3];
            Weapons weapons = new Weapons();
            weapons.name = "Repeater Rifle";
            weapons.price = 100;
            weapons.bDamage = 10;
            weapons.StrMod = 0;
            weapons.DexMod = 3;
            weapons.truDamage = bDamage + StrMod + DexMod;
            weapons.maxRange = 100;
            weapons.ammoPerShot = 1;
            weapons.ammoInMag = 8;
            Arsenal[0] = weapons;

            weapons.name = "Shotgun";
            weapons.price = 100;
            weapons.bDamage = 20;
            weapons.StrMod = 4;
            weapons.DexMod = 0;
            weapons.truDamage = bDamage + StrMod + DexMod;
            weapons.maxRange = 20;
            weapons.ammoPerShot = 2;
            weapons.ammoInMag = 2;
            Arsenal[1] = weapons;

            weapons.name = "Six-Shooter";
            weapons.price = 75;
            weapons.bDamage = 7;
            weapons.StrMod = 2;
            weapons.DexMod = 2;
            weapons.truDamage = bDamage + StrMod + DexMod;
            weapons.maxRange = 50;
            weapons.ammoPerShot = 1;
            weapons.ammoInMag = 6;
            Arsenal[2] = weapons;

            weapons.name = "PKD .223";
            weapons.price = 750;
            weapons.bDamage = 10;
            weapons.StrMod = 5;
            weapons.DexMod = 6;
            weapons.truDamage = bDamage + StrMod + DexMod;
            weapons.maxRange = 50;
            weapons.ammoPerShot = 1;
            weapons.ammoInMag = 6;
            Arsenal[2] = weapons;
        }
    }
    
}
