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
        public void TownEntrance()
        {
            sC.TB($"As the sun sets over the horizon, the skeletal silhouette of a town \nprotrudes from the skyline. \nPress Any Key to Continue...");
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
            sC.TB("You make your way to the center of town, on your left is an establishment\nnamed the Sasaparilla Saloon. On your right is a store named \nMom and Pop's Firearm Shoppe.");
            Console.WriteLine("Do you go [L]eft or [R]ight?");
        }
        public void Saloon()
        {
            bool checkpass = false;
            sC.TB("As you enter the bar you feel the piercing gaze of its inhabitants\nscanning every inch of your person.\n");
            Console.Clear();
            sC.TB($"Not to be deterred, you muster up your courage and prepare to make your entrance.\nPress [R] to roll for Constitution, or press enter to skip. \nCurrent Constitution: [{Program.p.Con}/15]");
            char temp = sC.RK(' ');
            if (temp == 'r')
            {
                if (h.R2H(0) + Program.p.Per >= 10)
                {
                    checkpass = true;
                    sC.TB("Check Success! \nYou stand up tall and puff out your chest, \npush open the batwing doors, and march up to the bar.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    sC.TB("Check Failed.\nCaving to the social pressures, you tip your hat over your eyes \nand shuffle to one of the corner seats.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            else
            {
                sC.TB("Caving to the social pressures, you tip your hat over your eyes \nand shuffle to one of the corner seats.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            if (checkpass)
            {
                bool shopping = true;
                while (shopping)
                {
                    Console.Clear();
                    sC.TB("The man behind the counter locks eyes with you, and asks \"So, what'll it be?\"");
                    Console.WriteLine("[1] Nothing\n[2] Cactus Wine\nDexterity +1\nGold: 25\n[3] Mule Skinner\nStrength +1\nGold: 25\n[4] Milk\nConstitution +1\nGold: 10\nPress [L] to leave.");
                    char tmp = sC.RK(' ');
                    if (tmp == '2')
                    {
                        Program.p.Dex++;
                        Program.p.Gold -= 25;
                    }
                    else if (tmp == '3')
                    {
                        Program.p.Str++;
                        Program.p.Gold -= 25;
                    }
                    else if (tmp == '4')
                    {
                        Program.p.Con++;
                        Program.p.Gold -= 10;

                    }
                    else
                    {
                        Console.Clear();
                        sC.TB("You collect your belongings and leave.");
                        shopping = false;
                    }
                }

            }
            else if (!checkpass)
            {
                Console.Clear();
                sC.TB("You sit in your seat of shame and get nothing.\nPress any key to leave.");
            }
        }
        public void Shop()
        {
            sC.TB($"\"Welcome to Mom & Pop's Firearm Shoppe!\"\nSays the bespectacled man behind the counter.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear(); 
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
                foreach (Weapons wep in Weapons.WeaponCheck)
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
            else if (test == "p")
            {
                //gives player PKD
                foreach (Weapons wep in Weapons.WeaponCheck)
                    if (wep.name == "PKD .223")
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
            else
            { }
        }
        void Hideout()
        {
            Program.p.HP = Program.p.Con * 4;
            int phase = 0;
            if(phase == 0)
            {
                Array[] enemies = new Array[2];
                sC.TB("You walk up to the hideout, three gang members are lingering outside and notice you. ");
                sC.RK(' ');
                Console.Clear();
            }
        }
    }
}
