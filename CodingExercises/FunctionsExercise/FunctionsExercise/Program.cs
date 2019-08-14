using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.score = 100;
            game.start();
            game.addToScore(0,0);
        }
    }
}
