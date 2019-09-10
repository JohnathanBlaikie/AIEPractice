using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    class Player
    {
        ShortCuts sC = new ShortCuts();
        Random r = new Random();
        Weapons weapons = new Weapons();
        public string name;
        public int Str, Dex, Int, Con, Per, Gold, Location;
        private string nameP;
        private int StrP, DexP, IntP, ConP, PerP, GoldP, PhaseP;
        public void LoadSave()
        {
            Console.Clear();
            name = sC.FRL(0);
            sC.ITP(sC.FRL(1),ref Str);
            sC.ITP(sC.FRL(2),ref Dex);
            sC.ITP(sC.FRL(3),ref Int);
            sC.ITP(sC.FRL(4),ref Con);
            sC.ITP(sC.FRL(5),ref Per);
            sC.ITP(sC.FRL(6),ref Gold);
            sC.ITP(sC.FRL(7), ref Location);
            Console.WriteLine($" Name: {name}\n Strength: {Str}\n Dexterity: {Dex}\n Intelligence: {Int}\n Constitution: {Con}\n Perception: {Per}\n Gold: {Gold}");
            foreach (Weapons w in Weapons.WeaponCheck)
            {
                if (w.ownedByPlayer == true)
                {
                    Console.WriteLine($" {w.name}");
                }
            }
        }
        public void CheckSave()
        {
            nameP = sC.FRL(0);
            sC.ITP(sC.FRL(1), ref StrP);
            sC.ITP(sC.FRL(2), ref DexP);
            sC.ITP(sC.FRL(3), ref IntP);
            sC.ITP(sC.FRL(4), ref ConP);
            sC.ITP(sC.FRL(5), ref PerP);
            sC.ITP(sC.FRL(6), ref GoldP);
            sC.ITP(sC.FRL(7), ref PhaseP);
            Console.WriteLine($" Name: {nameP}\n Strength: {StrP}\n Dexterity: {DexP}\n Intelligence: {IntP}\n Constitution: {ConP}\n Perception: {PerP}\n Gold: {GoldP}");
            StreamReader sr = new StreamReader("PlayerInv.csv");
            foreach(Weapons w in Weapons.WeaponsOwned)
            {
                Console.WriteLine(w.name);
            }
          

            //foreach (Weapons w in Weapons.WeaponCheck)
            //{
            //    if (Weapons.WeaponsOwned.)
            //    {
            //        Console.WriteLine($" {w.name}");
            //    }

            //    //if (w.ownedByPlayer == true)
            //    //{
            //    //    Console.WriteLine($" {w.name}");
            //    //}
            //}
        }
        public void CheckStats()
        {
            Console.WriteLine($" Name: {name}\n Strength: {Str}\n Dexterity: {Dex}\n Intelligence: {Int}\n Constitution: {Con}\n Perception: {Per}\n Gold: {Gold}");

            foreach (Weapons w in Weapons.WeaponsOwned)
            {
                Console.WriteLine($" {w.name}");
            }

            //foreach (Weapons w in Weapons.WeaponCheck)
            //{
            //    if (w.ownedByPlayer == true)
            //    {
            //        Console.WriteLine($" {w.name}");
            //    }
            //}
        }
        public void RandomStats()
        {
            Str = r.Next(2, 20);
            Dex = r.Next(2, 20);
            Con = r.Next(2, 20);
            Int = r.Next(2, 20);
            Per = r.Next(2, 20);
        }
        public void SaveStats()
        {
            StreamWriter writer = new StreamWriter("test.txt");
            writer.WriteLine(name);
            writer.WriteLine(Str);
            writer.WriteLine(Dex);
            writer.WriteLine(Int);
            writer.WriteLine(Con);
            writer.WriteLine(Per);
            writer.WriteLine(Gold);
            writer.WriteLine(Location);
            writer.Close();
            //using (StreamWriter w = new StreamWriter("WeaponStats1.csv"))
            //{
            //    w.WriteLine("Weapon Name,Price,Range (yd),Base Damage,Str Mod,Dex Mod,True Damage,Ammo Per Shot,Ammo in Mag,Owned by Player?");
            //    foreach (Weapons wp in Weapons.WeaponCheck)
            //    {
            //        //w.WriteLine("Weapon Name,Price,Range (yd),Base Damage,Str Mod,Dex Mod,True Damage,Ammo Per Shot,Ammo in Mag,Owned by Player?");
            //        w.WriteLine($"{wp.name},{wp.price},{wp.maxRange},{wp.bDamage},{wp.StrMod},{wp.DexMod},{wp.truDamage},{wp.ammoPerShot},{wp.ammoInMag},{wp.ownedByPlayer}");
                    
            //    }
            //    w.Close();
            //}
            using (StreamWriter w = new StreamWriter("PlayerInv.csv"))
            {
                foreach(Weapons wp in Weapons.WeaponCheck)
                {
                    if(wp.ownedByPlayer == true)
                    {
                        w.WriteLine($"{wp.name},{wp.price},{wp.maxRange},{wp.bDamage},{wp.StrMod},{wp.DexMod},{wp.truDamage},{wp.ammoPerShot},{wp.ammoInMag},{wp.ownedByPlayer}");
                    }
                    else
                    {

                    }
                }
                w.Close();
            }
            
            
          
        }

    }
}
