using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CRPG
{
    class Helpers
    {
        ShortCuts sC = new ShortCuts();
        Player p = new Player();
        Random r1 = new Random();
        Random r2 = new Random();
        Weapons weapons = new Weapons();

        //R2H is a shortcut for rolling to hit whatever the player is attacking.
        public int R2H(int d20)
        {
            d20 = r1.Next(1, 20);
            Console.WriteLine(d20);
            return d20;
        }
        //R2D4 is just a generic random combination.
        public int R2D4(int dSum)
        {
            dSum = r1.Next(1, 4) + r2.Next(1, 4);
            Console.WriteLine(dSum);
            return dSum;
        }

        //This is a set of randoms that operate on the DnD stat rules of: 
        //Roll 4d6, drop the lowest number, and add the remaining 3 to get your skill value.
        public int StatRoll(int dSum)
        {
            int[] d = new int[4];
            d[0] = r1.Next(1, 6);
            d[1] = r1.Next(1, 6);
            d[2] = r1.Next(1, 6);
            d[3] = r1.Next(1, 6);
            Array.Sort(d);
            d[0] = 0;
            dSum = d.Sum();
            return dSum;
        }

        public Player NewCharacter()
        {
            string temp, temp2, temp3, temp4, temp5;

            //foreach (Weapons w in Weapons.WeaponCheck)
            //{
            //    if (w.ownedByPlayer == true)
            //    {
            //        Weapons.WeaponsOwned.Add(w);
            //    }
            //    else
            //    {
            //        Weapons.WeaponsOwned.Remove(w);
            //    }
            //}
            Weapons.WeaponsOwned.Clear();
            foreach(Weapons w in Weapons.WeaponCheck)
            {
                if (w.ownedByPlayer == true)
                {
                    Weapons.WeaponsOwned.Add(w);
                }
            }
            sC.TB("\t Enter Your Character's Name");
            p.name = sC.RL("");
            temp = sC.WRL("Press R to roll for Strength");
            if (temp == "r")
            {
                Console.Clear();
                Console.WriteLine("Rolling...");
                Console.WriteLine($"Strength: {p.Str = StatRoll(0)}");
            }
            temp2 = sC.WRL("Press R to roll for Dexterity");
            if (temp2 == "r")
            {
                Console.Clear();
                Console.WriteLine("Rolling...");
                Console.WriteLine($"Dexterity: {p.Dex = StatRoll(0)}");
            }
            temp3 = sC.WRL("Press R to roll for Intelligence");
            if (temp3 == "r")
            {
                Console.Clear();
                Console.WriteLine("Rolling...");
                Console.WriteLine($"Intelligence: {p.Int = StatRoll(0)}");
            }
            temp4 = sC.WRL("Press R to roll for Constitution");
            if (temp4 == "r")
            {
                Console.Clear();
                Console.WriteLine("Rolling...");
                Console.WriteLine($"Constitution: {p.Con = StatRoll(0)}");
            }
            temp5 = sC.WRL("Press R to roll for Perception");
            if (temp5 == "r")
            {
                Console.Clear();
                Console.WriteLine("Rolling...");
                Console.WriteLine($"Perception: {p.Per = StatRoll(0)}");
                return p;
            }

            else
            {
                Console.WriteLine("invalid command");
                return null;
            }

        }

    }
}
