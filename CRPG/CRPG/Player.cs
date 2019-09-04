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
        public string name;
        public int Str, Dex, Int, Con, Per, Gold;
        private int StrP, DexP, IntP, ConP, PerP, GoldP;
        public void LoadSave()
        {
            name = sC.FRL(0);
            sC.ITP(sC.FRL(1),ref Str);
            sC.ITP(sC.FRL(2),ref Dex);
            sC.ITP(sC.FRL(3),ref Int);
            sC.ITP(sC.FRL(4),ref Con);
            sC.ITP(sC.FRL(5),ref Per);
            sC.ITP(sC.FRL(6),ref Gold);
            Console.WriteLine($" Name: {name}\n Strength: {Str}\n Dexterity: {Dex}\n Intelligence: {Int}\n Constitution: {Con}\n Perception: {Per}\n Gold: {Gold}");
        }
        public void CheckSave()
        {
            name = sC.FRL(0);
            sC.ITP(sC.FRL(1), ref StrP);
            sC.ITP(sC.FRL(2), ref DexP);
            sC.ITP(sC.FRL(3), ref IntP);
            sC.ITP(sC.FRL(4), ref ConP);
            sC.ITP(sC.FRL(5), ref PerP);
            sC.ITP(sC.FRL(6), ref GoldP);
            Console.WriteLine($" Name: {name}\n Strength: {StrP}\n Dexterity: {DexP}\n Intelligence: {IntP}\n Constitution: {ConP}\n Perception: {PerP}\n Gold: {GoldP}");
        }
        public void CheckStats()
        {
            Console.WriteLine($" Name: {name}\n Strength: {Str}\n Dexterity: {Dex}\n Intelligence: {Int}\n Constitution: {Con}\n Perception: {Per}\n Gold: {Gold}");
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
            writer.Close();
        }

    }
}
