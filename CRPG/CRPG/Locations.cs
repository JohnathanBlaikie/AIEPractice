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
        Enemies e = new Enemies();
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
            Console.WriteLine("Do you go [L]eft or [R]ight?\n Press [C] to view your character.");
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
                    if (tmp == '1')
                    {
                        Console.Clear();
                        sC.TB("You collect your belongings and leave.");
                        shopping = false;
                    }
                    if (tmp == '2' && Program.p.Gold >= 25)
                    {
                        Program.p.Dex++;
                        Program.p.Gold -= 25;
                    }
                    else if (tmp == '3' && Program.p.Gold >= 25)
                    {
                        Program.p.Str++;
                        Program.p.Gold -= 25;
                    }
                    else if (tmp == '4' && Program.p.Gold >= 10)
                    {
                        Program.p.Con++;
                        Program.p.Gold -= 10;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough gold for that drink.");
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
            foreach (Weapons w in Weapons.WeaponCheck)
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
        public void Hideout()
        {
            Program.p.HP = Program.p.Con * 4;
            int phase = 0;
            int eIDint = 0;
            int rep = 1;
            int wepInt = 0;
            bool inCombat = false;
            bool playerDeath = false;
            foreach (Weapons wep in Weapons.WeaponsOwned)
            {
                wep.cRam = rep;
                rep++;
            }
            if (!playerDeath)
            {
                if (phase == 0)
                {
                    sC.TB("You walk up to the hideout, three gang members are lingering outside and notice you. ");
                    sC.RK(' ');
                    Console.Clear();
                    eIDint = 0;

                    var ph0 = new List<Enemies>
                    {
                        new Thug(1),
                        new Thug(2),
                        new Thug(3)
                    };
                    inCombat = true;
                    while (inCombat)
                    {
                        if (Program.p.HP <= 0)
                        {
                            playerDeath = true;
                            inCombat = false;
                        }
                        Console.WriteLine("");
                        Console.Write("Name: ");
                        foreach (Enemies e in ph0)
                        {
                            Console.Write($"\t[{e.EID}] {e.Name}");
                        }
                        Console.Write("\nHealth: ");
                        foreach (Enemies e in ph0)
                        {
                            if (e.EHP > 0)
                                Console.Write($"{e.EHP}\t\t");
                            else
                                Console.Write("Dead\t\t");

                        }


                        Console.WriteLine();
                        Console.WriteLine($"Choose an enemy to attack\nCurrent Health: {Program.p.HP}");
                        sC.ITP(Console.ReadKey(true).KeyChar.ToString(), ref eIDint);
                        foreach (Enemies e in ph0)
                        {
                            if (eIDint == e.EID)
                            {
                                Console.WriteLine($"Choose a weapons to use");
                                foreach (Weapons wep in Weapons.WeaponsOwned)
                                {
                                    Console.Write($"[{wep.cRam}] {wep.name}\t");
                                }
                                Console.WriteLine("");
                                foreach (Weapons wep in Weapons.WeaponsOwned)
                                {
                                    Console.Write($"Damage: {wep.truDamage = wep.bDamage + (Program.p.Dex * wep.DexMod) + (Program.p.Str * wep.StrMod)}\t\t");
                                }
                                sC.ITP(Console.ReadKey(true).KeyChar.ToString(), ref wepInt);
                                foreach (Weapons wep in Weapons.WeaponsOwned)
                                {
                                    if (wepInt == wep.cRam)
                                    {
                                        e.EHP -= wep.truDamage;
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        int deadT = 0;
                        foreach (Enemies eCheck in ph0)
                        {
                            if (eCheck.EHP <= 0)
                                eCheck.IsAlive = false;

                            if (eCheck.IsAlive)
                            {
                                int tInt = h.R2H(0) + 7;
                                if (tInt >= Program.p.Per + Program.p.Dex)
                                {
                                    Console.WriteLine($"{eCheck.DPT} Damage Taken from thug [{eCheck.EID}]");
                                    Program.p.HP -= eCheck.DPT;
                                }
                                else
                                {
                                    Console.WriteLine($"Thug [{eCheck.EID}] missed!");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Thug [{eCheck.EID}] is dead.");
                                deadT++;
                            }
                            if (deadT >= 3)
                            {
                                sC.TB($"You collected {eCheck.Bounty * 3} Gold from their bounties");
                                Program.p.Gold += eCheck.Bounty * 3;
                                inCombat = false;
                                phase = 1;
                            }
                        }
                    }
                }

                if (phase == 1)
                {
                    sC.TB("As you push in through the entrance, you run into a captain and his guards investigating the commotion.\nPress [R] to retreat or [Enter] continue");
                    char tempchar = sC.RK(' ');
                    if (tempchar == 'r')
                    {
                        phase = 3;
                        Program.p.Location = 1;
                        inCombat = false;
                    }

                    var ph1 = new List<Enemies>
                    {
                    new Thug(1),
                    new Thug(2),
                    new Captain(3)
                    };
                    Console.Clear();
                    eIDint = 0;
                    inCombat = true;
                    while (inCombat)
                    {

                        if (Program.p.HP <= 0)
                        {
                            playerDeath = true;
                            inCombat = false;
                        }
                        Console.WriteLine("");
                        Console.Write("Name: ");
                        foreach (Enemies e in ph1)
                        {
                            Console.Write($"\t[{e.EID}] {e.Name}");
                        }
                        Console.Write("\nHealth: ");
                        foreach (Enemies e in ph1)
                        {
                            if (e.EHP > 0)
                                Console.Write($"{e.EHP}\t\t");
                            else
                                Console.Write("Dead\t\t");

                        }

                        Console.WriteLine();
                        Console.WriteLine($"Choose an enemy to attack\nCurrent Health: {Program.p.HP}");
                        sC.ITP(Console.ReadKey(true).KeyChar.ToString(), ref eIDint);
                        foreach (Enemies e in ph1)
                        {
                            if (eIDint == e.EID)
                            {
                                Console.WriteLine($"Choose a weapons to use");
                                foreach (Weapons wep in Weapons.WeaponsOwned)
                                {
                                    Console.Write($"[{wep.cRam}] {wep.name}\t");
                                }
                                Console.WriteLine("");
                                foreach (Weapons wep in Weapons.WeaponsOwned)
                                {
                                    Console.Write($"{wep.truDamage = wep.bDamage + (Program.p.Dex * wep.DexMod) + (Program.p.Str * wep.StrMod)}\t\t");
                                }
                                sC.ITP(Console.ReadKey(true).KeyChar.ToString(), ref wepInt);
                                foreach (Weapons wep in Weapons.WeaponsOwned)
                                {
                                    if (wepInt == wep.cRam)
                                    {
                                        e.EHP -= wep.truDamage;
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        int deadT = 0;
                        foreach (Enemies eCheck in ph1)
                        {
                            if (eCheck.EHP <= 0)
                                eCheck.IsAlive = false;

                            if (eCheck.IsAlive)
                            {
                                int tInt = h.R2H(0) + 7;
                                if (tInt >= Program.p.Per + Program.p.Dex)
                                {
                                    Console.WriteLine($"{eCheck.DPT} Damage Taken from {eCheck.Name} [{eCheck.EID}]");
                                    Program.p.HP -= eCheck.DPT;
                                }
                                else
                                {
                                    Console.WriteLine($"{eCheck.Name} [{eCheck.EID}] missed!");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{eCheck.Name} [{eCheck.EID}] is dead.");
                                deadT++;
                            }
                            if (deadT >= 3)
                            {
                                int tInt = 0;
                                foreach (Enemies eDeath in ph1)
                                {
                                    tInt += eDeath.Bounty;
                                }
                                sC.TB($"You collected {eCheck.Bounty * 3} Gold from their bounties");
                                Program.p.Gold += tInt;
                                inCombat = false;
                                phase = 2;
                            }
                        }

                    }
                }
                if(phase == 3)
                {

                }
                
                
            }
            if (playerDeath)//something is preventing the player from leaving at the the beginning of phase 1 (2) figure it out.
            {
                sC.TB("You have died.");
                playerDeath = true;
                sC.RK(' ');
            }
        }
    }
}
