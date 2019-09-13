using System;
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

            try { w.PreviousSaveCheck(); }
            catch
            {
                StreamWriter sW = new StreamWriter("PlayerInv.csv");
                sW.Close();
            }
            w.InventoryInstantiation();

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
                    try
                    {
                        //w.InventoryInstantiation();
                        p.LoadSave();
                        Location = p.Location;
                        loadNew = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid data! please create a new character.");
                    }
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
                    Location = 1;
                }
                if (Location == 1)
                {
                    l.TownSquare();
                    p.Location = 1;
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
                    try { p.CheckSave(); }
                    catch { Console.WriteLine("No Existing Previous Save."); }
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
                            try
                            {
                                //w.InventoryInstantiation();
                                p.LoadSave();
                                Location = p.Location;
                                loadNew = false;
                            }
                            catch
                            {
                                Console.WriteLine("Save data is invalid or corrupt. Please make a new save file.");
                            }
                        }
                        else if (tempchar == 'e')
                        {
                            Console.Clear();
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
                    Console.WriteLine("Press Enter to Continue");
                    sC.RL("");
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
            }
        }
    }
}
