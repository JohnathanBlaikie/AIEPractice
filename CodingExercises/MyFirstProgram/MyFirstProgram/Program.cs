using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name;
           // name = Console.ReadLine();
            char menuItem = 'X'; //temp to store inputs
            bool quit = false;

            Console.WriteLine("\t High \n \t Noon");
            while (menuItem != 'a' && menuItem != 'b' && menuItem != 'c')
            //while (!quit)
            {
               
                
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(" You enter an old tavern\n\n Do you: [A] Walk up to the bar [B] Sit at one of the empty booths [C] Sit at one of the communal tables");
                menuItem = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (menuItem == 'A')
                {
                    Console.Clear();
                    Console.WriteLine(" You take a seat along the bar. An elderly, bespectacled gentlemen moves down the row and asks what he can get you to drink");
                    //quit = true;
                    break;
                    //Console.ReadKey();
                }
                else if (menuItem == 'B')
                {
                    Console.Clear();
                }
                //if (Console.ReadKey())
                //{

                //}
            }
        }
    }
}
