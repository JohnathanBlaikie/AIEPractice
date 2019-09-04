using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    class Helpers
    {
        ShortCuts sC = new ShortCuts();
        Player p = new Player();
        Random r1 = new Random();
        Random r2 = new Random();
        public int R2H(int d20)
        {
            d20 = r1.Next(1, 20);
            Console.WriteLine(d20);
            return d20;
        }
        public int R2D4(int dSum)
        {
            dSum = r1.Next(1, 4) + r2.Next(1, 4);
            Console.WriteLine(dSum);
            return dSum;
        }
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
            //Console.WriteLine($"{d[0]}, {d[1]}, {d[2]}, {d[3]}");
            //Console.ReadKey();
            //Array.Sort(d);
            //Console.WriteLine($"{d[0]}, {d[1]}, {d[2]}, {d[3]}");
            //Console.ReadKey();
            //d[0] = 0;
            //Console.WriteLine($"{d[0]}, {d[1]}, {d[2]}, {d[3]}");
            //Console.ReadKey();
            //dSum = d.Sum();
            //Console.WriteLine(dSum);
            //Console.ReadKey();

        }
        public Player NewCharacter()
        {
            int[] tempstats = new int[5];
            int[] stats = new int[5];
            string temp, temp2, temp3, temp4;
            sC.TB("\t Enter Your Character's Name");
            p.name = sC.RL("");
            //for (int i = 0; i < 5; i++)
            //{
            //    tempstats[i] = h.StatRoll(0);
            //}
            temp = sC.WRL("Press R to roll for Strength");
            if (temp == "r")
            {
                Console.WriteLine($"Strength: {p.Str = StatRoll(0)}");
            }
            temp2 = sC.WRL("Press R to roll for Dexterity");
            if (temp2 == "r")
            {
                Console.WriteLine($"Dexterity: {p.Dex = StatRoll(0)}");
            }
            temp3 = sC.WRL("Press R to roll for Intelligence");
            if (temp3 == "r")
            {
                Console.WriteLine($"Intelligence: {p.Int = StatRoll(0)}");
            }
            temp4 = sC.WRL("Press R to roll for Constitution");
            if (temp4 == "r")
            {
                Console.WriteLine($"Constitution: {p.Con = StatRoll(0)}");
            }
            temp4 = sC.WRL("Press R to roll for Perception");
            if (temp4 == "r")
            {
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
