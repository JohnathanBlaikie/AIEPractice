using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGate
{
    class Program
    {
        static void Main(string[] args)
        {
            string uName;
            int uAge, nBPurchase;
            Console.WriteLine("Hello, User! Please enter your name.");
            uName = Console.ReadLine();
            Console.WriteLine("Alright, " + uName + ", Please enter your age.");
            uAge = Convert.ToInt32(Console.ReadLine());
            if (uAge < 18)
            {
                Console.WriteLine(uAge + "? No, you're not.");
                Console.ReadKey();
            }
            if (uAge >= 18 && uAge < 50)
            {
                Console.WriteLine(uAge + "? Alright, that checks out.");
                Console.ReadKey();
            }
            if (uAge >= 50 && uAge < 65)
            {
                Console.WriteLine(uAge + "? Geez, I don't suppose you've joined AARP yet?");
                Console.ReadKey();
            }
            if (uAge >= 65)
            {
                Console.WriteLine(uAge + "? Wow. I'm shocked you've manage to get this far in the program.");
                Console.ReadKey();
            }
            Console.WriteLine("Alright, " + uName + ", How many sketchbook packs can I put you down for? " +
                "\nEach pack comes with 3 sketchbooks, and we can only ship them if you order 3 packs (9 sketchbooks) minimum." +
                "\nEach customer is limited to a maximum of 10 packs (30 sketchbooks)");
            nBPurchase =  Convert.ToInt32(Console.ReadLine());
            if (nBPurchase >= 3 && nBPurchase <= 10)
            {
                Console.WriteLine("Wonderful! Your order of " + nBPurchase + " sketchbook bundles has been confirmed!");
                Console.ReadKey();
            }
            while (nBPurchase > 10 || nBPurchase < 3)
            {
                if (nBPurchase < 3)
                {
                    Console.WriteLine("Sorry, but " + nBPurchase + " sketchbook bundles is unfortunately too few for us to ship");
                    Console.WriteLine("Please enter an order size between 3 and 10.");
                    nBPurchase = Convert.ToInt32(Console.ReadLine());
                }
                if (nBPurchase >= 3 && nBPurchase <= 10)
                {
                    Console.WriteLine("Wonderful! Your order of " + nBPurchase + " sketchbook bundles has been confirmed!");
                    Console.ReadKey();
                }
                if (nBPurchase > 10)
                {
                    Console.WriteLine("Sorry, but " + nBPurchase + " is too many. Unfortunately we cannot sell more than 30 sketchbooks to any one customer");
                    Console.WriteLine("Please enter an order size between 3 and 10.");
                    nBPurchase = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
