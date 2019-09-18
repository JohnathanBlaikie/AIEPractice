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
        public bool isDead;
        public int Str, Dex, Int, Con, Per, Gold, Location, HP;
        private string nameP;
        private int StrP, DexP, IntP, ConP, PerP, GoldP, LocationP;
        
        //Reads the test.txt file and the PlayerInv.csv and applies their data to the current player.
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
            Console.WriteLine($" Name: {name}\n Strength: {Str}\n Dexterity: {Dex}" +
                $"\n Intelligence: {Int}\n Constitution: {Con}\n Perception: {Per}\n Gold: {Gold}");
            using (StreamReader sR = new StreamReader("PlayerInv.csv"))
            {
                Weapons.WeaponsOwned.Clear();
                foreach (Weapons w in Weapons.PreviousSave)
                {
                    Weapons temp = new Weapons();
                    string line = sR.ReadLine();
                    string[] Values = line.Split(',');
                    temp.name = Values[0];
                    temp.price = int.Parse(Values[1]);
                    temp.maxRange = int.Parse(Values[2]);
                    temp.bDamage = int.Parse(Values[3]);
                    temp.StrMod = int.Parse(Values[4]);
                    temp.DexMod = int.Parse(Values[5]);
                    temp.ammoPerShot = int.Parse(Values[7]);
                    temp.ammoInMag = int.Parse(Values[8]);
                    temp.ownedByPlayer = bool.Parse(Values[9]);
                    Weapons.WeaponsOwned.Add(temp);
                }
                sR.Close();
            }
            foreach (Weapons w in Weapons.WeaponsOwned)
            {
                Console.WriteLine($" {w.name}");  
            }
        }
        //Looks at the previous save and displays its information
        public void CheckSave()
        {
            nameP = sC.FRL(0);
            sC.ITP(sC.FRL(1), ref StrP);
            sC.ITP(sC.FRL(2), ref DexP);
            sC.ITP(sC.FRL(3), ref IntP);
            sC.ITP(sC.FRL(4), ref ConP);
            sC.ITP(sC.FRL(5), ref PerP);
            sC.ITP(sC.FRL(6), ref GoldP);
            sC.ITP(sC.FRL(7), ref LocationP);
            Console.WriteLine($" Name: {nameP}\n Strength: {StrP}\n Dexterity: {DexP}\n Intelligence: {IntP}\n Constitution: {ConP}\n Perception: {PerP}\n Gold: {GoldP}");
            Weapons.PreviousSave.Clear();
            weapons.PreviousSaveCheck();
            foreach (Weapons w in Weapons.PreviousSave)
            {
                Console.WriteLine($" {w.name}");
            }
        }
        //Looks at the current information of the player that has yet to be saved.
        public void CheckStats()
        {
            Console.WriteLine($" Name: {name}\n Strength: {Str}\n Dexterity: {Dex}\n Intelligence: {Int}\n Constitution: {Con}\n Perception: {Per}\n Gold: {Gold}");

            foreach (Weapons w in Weapons.WeaponsOwned)
            {
                Console.WriteLine($" {w.name}");
            }
        }
        //Random Stats is a remnant of how I origionally did the stat rolls, it serves no *real* purpose now.
        public void RandomStats()
        {
            Str = r.Next(2, 20);
            Dex = r.Next(2, 20);
            Con = r.Next(2, 20);
            Int = r.Next(2, 20);
            Per = r.Next(2, 20);
        }
        //Saves the player's current information.
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
            
            using (StreamWriter w = new StreamWriter("PlayerInv.csv"))
            {
                foreach(Weapons wp in Weapons.WeaponsOwned)
                {
                    w.WriteLine($"{wp.name},{wp.price},{wp.maxRange},{wp.bDamage},{wp.StrMod},{wp.DexMod},{wp.truDamage},{wp.ammoPerShot},{wp.ammoInMag},{wp.ownedByPlayer}");
                }
                w.Close();
            }
          
        }

    }
}
