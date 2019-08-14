using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHealth;
            bool combat = false;
            int monsterHealth = 100;

            playerHealth = 100;
            monsterHealth = 50;

            
            string battleStartText = "A fierce monster launches a surprise attack!";
            Console.WriteLine(battleStartText);
            Console.ReadKey();
            string health = "You are at " + playerHealth + " HP" + "\nMonster is at " + monsterHealth + " HP";
            Console.WriteLine(health);
            Console.ReadKey();
        }
    }
}
