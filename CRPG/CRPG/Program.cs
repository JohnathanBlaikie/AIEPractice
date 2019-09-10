﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    class Program
    {
           public  static Player p = new Player();
        static void Main(string[] args)
        {
            
            int Location = 0;
            bool first = true;
            bool close = false;
            bool loadNew = true;
            ShortCuts sC = new ShortCuts();
            Helpers h = new Helpers();
            Locations l = new Locations();
            Weapons w = new Weapons();
            
            
            w.ArsenalInstantiation();

            sC.TB("CRPG NAME HERE");
            Console.WriteLine("Press Enter to begin...");
            sC.RL("");
            while (loadNew)
            {
                Console.WriteLine("Would You Like to [L]oad a Save or Start a [N]ew Adventure?");
                char LN = sC.RK(' ');
                if (LN == 'n')
                {
                    p = h.NewCharacter();
                    Location = 0;
                    loadNew = false;
                }
                else if (LN == 'l')
                {
                    p.LoadSave();
                    Location = p.Location;
                    loadNew = false;
                }
                else
                {
                    Console.WriteLine("Invalid Command.");
                }
            }
            while (!close)
            {

                if (Location == 0)
                {
                    l.TownEntrance();
                    Location++;
                }
                if (Location == 1)
                {
                    l.TownSquare();

                }
                

                Console.WriteLine("Type [C] to check your stats, or [V] to view your last save");
                char tempchar = sC.RK(' ');
                Console.Clear();
                if (tempchar == 'v')
                {
                    bool savestate = true;
                    Console.WriteLine($"Current Stats:");
                    p.CheckStats();
                    Console.WriteLine("\nPrevious Save:");
                    p.CheckSave();
                    Console.WriteLine("\nPress [L] to load your pervious save, or [S] to overwrite it.\n\nPress [E] to Exit\n");
                    while (savestate)
                    {
                        tempchar = sC.RK(' ');
                        if (tempchar == 's')
                        {
                            p.SaveStats();
                            savestate = false;
                        }
                        else if (tempchar == 'l')
                        {
                            p.LoadSave();
                            savestate = false;
                        }
                        else if (tempchar == 'e')
                        {
                            savestate = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid command");
                        }
                    }
                }
                else if (tempchar == 'c')
                {
                    p.CheckStats();
                }
                else if (tempchar == 'r')
                {
                    p.RandomStats();
                }
                else if (tempchar == 's')
                {
                    l.Shop();
                }
                else if (tempchar == 'q')
                {
                    close = true;
                }
                else if (tempchar == 'w')
                {
                    w.ArsenalListing();
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
            }
        }
    }
}
