using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExercise
{
    class Game
    {
        public int score = 0;
        public void start()
        {
            Console.WriteLine($"Your score is currently {score}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            
        }
        public int addToScore(int add, int oldScore)
        {
            bool want2Retry = true;
            while (want2Retry == true)
            {
                Console.Clear();
                Console.WriteLine($"Your score is currently {score}");
                Console.WriteLine("Please enter the amount of points you would like to add to your current pool.");
                add = Convert.ToInt32(Console.ReadLine());
                oldScore = score;
                score = add + score;
                Console.WriteLine($"Your score is currently {score}, after adding {add} to {oldScore}");
                Console.WriteLine($"Would you like to add some more? \n\t [Y] [N]");
                char answer = char.ToLower(Console.ReadKey(true).KeyChar);
                if (answer == 'y')
                {
                    want2Retry = true;
                }
                if (answer == 'n')
                {
                    want2Retry = false;
                }
            }
            return score;
        }
    }
}
