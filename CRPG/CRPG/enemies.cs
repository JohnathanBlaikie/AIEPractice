using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CRPG
{
    public class Enemies
    {   
        public string Name { get; set; }
        public int EHP { get; set; }
        public int EID { get; set; }
        public int DPT { get; set; }
        public int Bounty { get; set; }
        public bool IsAlive { get; set; }
        public virtual void SetStat()
        {

        }
    }
    public class Thug : Enemies
    {
        public Thug(int eid)
        {
            EID = eid;
            Name = "Thug";
            EHP = 50;
            DPT = 15;
            Bounty = 25;
            IsAlive = true;
            //Console.WriteLine($"Thug\n{EHP}\n{Bounty}");
        }
        public Thug()
        {
            
        }
    }
    public class Captain : Enemies
    {
        public Captain(int eid)
        {
            EID = eid;
            Name = "Captain";
            EHP = 60;
            DPT = 20;
            Bounty = 50;
            IsAlive = true;
            //Console.WriteLine($"Captain\n{EHP}\n{Bounty}");
        }
        public Captain()
        {

        }
    }
    public class Honcho : Enemies
    {
        public Honcho(int eid)
        {
            EID = eid;
            Name = "Honcho";
            EHP = 70;
            DPT = 25;
            Bounty = 100;
            IsAlive = true;
            //Console.WriteLine($"Honcho\n{EHP}\n{Bounty}");
        }
        public Honcho()
        {

        }
    }
}
