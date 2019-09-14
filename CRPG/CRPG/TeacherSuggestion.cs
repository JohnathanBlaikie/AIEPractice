
//    using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace CRPG
//{
//    class TeacherSuggestion 
//    {

//        //public class InvItem {
//        //    public string name;
//        //    public int price, bDamage, StrMod, DexMod, truDamage, maxRange, ammoPerShot, ammoInMag,qtyheld;
//        //    public bool ownedByPlayer;
//        //};

//        //public class Inventory
//        //{
//        //    public List<InvItem> MyItems = new List<InvItem>();
//        //    string MyFielname = "";

//        //    public Inventory(string filename)
//        //    {

//        //        LoadInvFromDisk(filename);
//        //    }


//        //    public void LoadInvFromDisk(string filename)
//        //    {

//        //        MyItems.Clear();
//        //        MyFielname = filename;
//        //        //Then....
//        //        //load the csv file from filename into a temporary List<InvItem> and return that 
//        //        //Read in the CSV file and load all the data into MyItems
//        //        using (StreamReader sr = new StreamReader(filename))
//        //        {
//        //            sr.ReadLine();
//        //            while (!sr.EndOfStream)
//        //            {
//        //                string line = sr.ReadLine();
//        //                string[] Values = line.Split(',');
//        //                Weapons tmpWeapon = new Weapons();
//        //                InvItem tmpItem = new InvItem();
//        //                tmpItem.name = Values[0];
//        //                tmpItem.price = int.Parse(Values[1]);
//        //                tmpItem.maxRange = int.Parse(Values[2]);
//        //                tmpItem.bDamage = int.Parse(Values[3]);
//        //                tmpItem.StrMod = int.Parse(Values[4]);
//        //                tmpItem.DexMod = int.Parse(Values[5]);
//        //                //tmpWeapon.truDamage = int.Parse(Values[6]);
//        //                tmpItem.ammoPerShot = int.Parse(Values[7]);
//        //                tmpItem.ammoInMag = int.Parse(Values[8]);
//        //                tmpItem.ownedByPlayer = bool.Parse(Values[9]);
//        //                MyItems.Add(tmpItem);
//        //            }
//        //            sr.Close();
//        //        }





//        //    }
//        //    public void SaveToDisk()
//        //    {
//        //        //Save the data to MyFilename

//        //    }

//        //    public void Add(InvItem tmpItem)
//        //    {
//        //        bool AlreadyHas = false;
//        //        foreach (InvItem tmpi in MyItems) {
//        //            if (tmpi.name == tmpItem.name)
//        //            {
//        //                AlreadyHas = true;
//        //                tmpi.qtyheld++;
//        //            }
//        //        }
//        //        if (!AlreadyHas)
//        //        {
//        //            MyItems.Add(tmpItem);
//        //            MyItems[MyItems.Count].qtyheld = 1;
//        //        }
//        //    }
//        //}


//        class Player
//        {
//            ShortCuts sC = new ShortCuts();
//            Random r = new Random();
//            Weapons weapons = new Weapons();
//            //---- Approach 2
//            //        Inventory PlayersInv = new Inventory("PlayerInv.csv");
//            //Inventory WeaponStore2 = new Inventory("WeaponStats1.csv");

//            //        public void mycode()
//            //        {
//            //            WeaponStore2.LoadInvFromDisk("WeaponStats1.csv");
//            //            PlayersInv.LoadInvFromDisk("PlayerInv.csv");


//            //            //player buys somethign / acquires


//            //            InvItem tmp = new InvItem();
//            //            PlayersInv.Add(WeaponStore2.MyItems[2]);
//            //            WeaponStore2.MyItems[2].qtyheld--;

//            //            //buyers remorse
//            //            PlayersInv.LoadInvFromDisk("PlayerInv.csv");

//            //            //on exit from store or whole game
//            //            //save playerinventory out to disk
//            //            PlayersInv.SaveToDisk();

//            //        }




//            //        //----




//            //        //----- Approach 1
//            //        public static List<InvItem> WeaponStore = new List<InvItem>();
//            //        //List<InvItem> PrevSave = new List<InvItem>();
//            //        public static List<InvItem> PlayerInventory = new List<InvItem>();

//            //        public static List<InvItem> LoadInvFromDisk(string filename)
//            //        {
//            //            List<InvItem> tmpReturn = new List<InvItem>();

//            //            //load the csv file from filename into a temporary List<InvItem> and return that 

//            //            return tmpReturn;
//            //        }

//            //        public static void InitializeGameInvs()
//            //        {
//            //            WeaponStore = LoadInvFromDisk("WeaponStats1.csv");
//            ////            PrevSave = LoadInvFromDisk("PlayerInv.csv");
//            //            PlayerInventory = LoadInvFromDisk("PlayerInv.csv");
//            //        }
//            //        //-----


//            public string name;
//            public int Str, Dex, Int, Con, Per, Gold, Location;
//            private string nameP;
//            private int StrP, DexP, IntP, ConP, PerP, GoldP, LocationP;

//            //This is what allows the user to create a new character.

//            public void LoadSave()
//            {
//                Console.Clear();
//                name = sC.FRL(0);
//                sC.ITP(sC.FRL(1), ref Str);
//                sC.ITP(sC.FRL(2), ref Dex);
//                sC.ITP(sC.FRL(3), ref Int);
//                sC.ITP(sC.FRL(4), ref Con);
//                sC.ITP(sC.FRL(5), ref Per);
//                sC.ITP(sC.FRL(6), ref Gold);
//                sC.ITP(sC.FRL(7), ref Location);
//                //Weapons.WeaponsOwned = Weapons.PreviousSave;
//                Console.WriteLine($" Name: {name}\n Strength: {Str}\n Dexterity: {Dex}" +
//                    $"\n Intelligence: {Int}\n Constitution: {Con}\n Perception: {Per}\n Gold: {Gold}");
//                using (StreamReader sR = new StreamReader("PlayerInv.csv"))
//                {
//                    Weapons.WeaponsOwned.Clear();
//                    foreach (Weapons w in Weapons.PreviousSave)
//                    {
//                        Weapons temp = new Weapons();
//                        string line = sR.ReadLine();
//                        string[] Values = line.Split(',');
//                        temp.name = Values[0];
//                        temp.price = int.Parse(Values[1]);
//                        temp.maxRange = int.Parse(Values[2]);
//                        temp.bDamage = int.Parse(Values[3]);
//                        temp.StrMod = int.Parse(Values[4]);
//                        temp.DexMod = int.Parse(Values[5]);
//                        temp.ammoPerShot = int.Parse(Values[7]);
//                        temp.ammoInMag = int.Parse(Values[8]);
//                        temp.ownedByPlayer = bool.Parse(Values[9]);
//                        Weapons.WeaponsOwned.Add(temp);
//                    }
//                    sR.Close();
//                }

//                //Weapons.WeaponsOwned.Clear();
//                //weapons.InventoryInstantiation();
//                foreach (Weapons w in Weapons.WeaponsOwned)
//                {
//                    Console.WriteLine($" {w.name}");
//                }
//            }
//            public void CheckSave()//Looks at the previous save and displays its information
//            {
//                nameP = sC.FRL(0);
//                sC.ITP(sC.FRL(1), ref StrP);
//                sC.ITP(sC.FRL(2), ref DexP);
//                sC.ITP(sC.FRL(3), ref IntP);
//                sC.ITP(sC.FRL(4), ref ConP);
//                sC.ITP(sC.FRL(5), ref PerP);
//                sC.ITP(sC.FRL(6), ref GoldP);
//                sC.ITP(sC.FRL(7), ref LocationP);
//                Console.WriteLine($" Name: {nameP}\n Strength: {StrP}\n Dexterity: {DexP}\n Intelligence: {IntP}\n Constitution: {ConP}\n Perception: {PerP}\n Gold: {GoldP}");
//                Weapons.PreviousSave.Clear();
//                weapons.PreviousSaveCheck();
//                foreach (Weapons w in Weapons.PreviousSave)
//                {
//                    Console.WriteLine($" {w.name}");
//                }
//            }
//            public void CheckStats()//Looks at the current information of the player that has yet to be saved
//            {
//                Console.WriteLine($" Name: {name}\n Strength: {Str}\n Dexterity: {Dex}\n Intelligence: {Int}\n Constitution: {Con}\n Perception: {Per}\n Gold: {Gold}");

//                foreach (Weapons w in Weapons.WeaponsOwned)
//                {
//                    Console.WriteLine($" {w.name}");
//                }
//            }
//            public void RandomStats()
//            {
//                Str = r.Next(2, 20);
//                Dex = r.Next(2, 20);
//                Con = r.Next(2, 20);
//                Int = r.Next(2, 20);
//                Per = r.Next(2, 20);
//            }
//            public void SaveStats()//saves the player's current information.
//            {
//                StreamWriter writer = new StreamWriter("test.txt");
//                writer.WriteLine(name);
//                writer.WriteLine(Str);
//                writer.WriteLine(Dex);
//                writer.WriteLine(Int);
//                writer.WriteLine(Con);
//                writer.WriteLine(Per);
//                writer.WriteLine(Gold);
//                writer.WriteLine(Location);
//                writer.Close();

//                using (StreamWriter w = new StreamWriter("PlayerInv.csv"))
//                {
//                    foreach (Weapons wp in Weapons.WeaponsOwned)
//                    {
//                        w.WriteLine($"{wp.name},{wp.price},{wp.maxRange},{wp.bDamage},{wp.StrMod},{wp.DexMod},{wp.truDamage},{wp.ammoPerShot},{wp.ammoInMag},{wp.ownedByPlayer}");
//                    }
//                    w.Close();
//                }

//            }

//        }
//    }

//}
//}
