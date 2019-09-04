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
        public string RK(string rK)
        {
            rK = Console.ReadKey().ToString();
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
