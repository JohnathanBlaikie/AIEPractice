using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;

namespace CRPG
{
    class ShortCuts
    {
        //Misc function that wraps text in a textbox
        public string TB(string tB)
        {
            Console.WriteLine($"_________________________________________" +
            $"\n{tB}\n_________________________________________");
            return tB;
        }
        //Shortcut for Console.ReadLine();
        public string RL(string rL)
        {
            rL = Console.ReadLine();
            return rL;
        }
        public string WRL(string rL)
        {
            Console.WriteLine(rL);
            rL = Console.ReadLine();
            return rL;
        }
        public char RK(char rK)
        {
            rK = char.ToLower(Console.ReadKey(true).KeyChar);
            return rK;
        }
        //Helper function that reads from a specific line
        public string FRL(int x)
        {
            return File.ReadLines("test.txt").ElementAt(x);
        }
        //Int.TryParse
        public void ITP(string x, ref int y)
        {
            int.TryParse(x, out y);
        }
        //int.TryParse but with POLYMORPHISM!
        public void ITP(string a, ref int b, string x, ref int y)
        {
            int.TryParse(a, out b);
            int.TryParse(x, out y);
        }
        //This pauses the script from running for 'x' seconds. 
        //It's multiplied by 1000 for the sake of convenience, as 1000 = 1 second.
        public void STTS(int x)
        {
            System.Threading.Thread.Sleep(x*1000);
        }

        
        //public string FWL(string fWL)
        //{
        //    StreamWriter writer = new StreamWriter("test.txt");
        //    //fWL = Console.ReadLine();
        //    writer.WriteLine(fWL);
        //    writer.Close();
        //    return fWL;
        //}

    }
}
