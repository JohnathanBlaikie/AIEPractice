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
        //
        static void Main(string[] args)
        {
            bool close = false;
            ShortCuts sC = new ShortCuts();
            Helpers h = new Helpers();
            Player p = new Player();
            sC.TB("CRPG NAME HERE");
            Console.WriteLine("Press Enter to begin...");
            sC.RL("");
            Console.WriteLine("Would You Like to [L]oad a Save or Start a [N]ew Adventure?");
            string LN = sC.RL("");
            if(LN == "n")
            {
                p = h.NewCharacter();
            }
            while (!close)
            {
                Console.WriteLine("Type [c] to check your stats, [r] to randomize your stats, \n[v] to view your last save, [l] to load your pervious save, or [s] to overwrite it.");
                string tempchar = sC.RL("");
                if (tempchar == "v")
                {
                    p.CheckSave();
                }
                else if (tempchar == "c")
                {
                    p.CheckStats();
                }
                else if (tempchar == "r")
                {
                    p.RandomStats();
                }
                else if (tempchar == "s")
                {
                    p.SaveStats();
                }
                else if (tempchar == "l")
                {
                    p.LoadSave();
                }
                else if (tempchar == "q")
                {
                    close = true;
                }
                else if (tempchar == "roll")
                {
                    bool dicechecker = false;
                    while (dicechecker == false)
                    {
                        string tempchar2 = sC.RL("");
                        h.StatRoll(0);
                        if(tempchar2 == "ok")
                        {
                            dicechecker = true;
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
               
            }
        }
    }
}
