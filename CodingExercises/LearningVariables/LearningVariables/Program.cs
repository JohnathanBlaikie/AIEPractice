using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVariables
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello, User! the game's start condition is: ";
            bool gamerMoment = false;
            float pogchamp = 12;
            string displayGameState = greeting + gamerMoment + " " +pogchamp;
            Console.WriteLine(displayGameState);

            gamerMoment = true;
            displayGameState = greeting + gamerMoment + " " + (pogchamp + 15);
            Console.WriteLine(displayGameState);
            Console.ReadKey();
        }
    }
}
