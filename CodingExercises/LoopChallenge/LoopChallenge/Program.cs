using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci
            bool retry = true;
            while (retry)
            {
                Console.Clear();
                int uNum = 0, gNum = 1, tNum, i, number;
                Console.WriteLine("Welcome, User. Please enter a number.");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{uNum} \n{gNum} ");
                for (i = 2; i < number; i++)
                {
                    tNum = uNum + gNum;
                    Console.WriteLine(tNum);
                    uNum = gNum;
                    gNum = tNum;
                }
                Console.WriteLine("Would you like to try another set?\n\t[Y] [N]");
                char answer = char.ToLower(Console.ReadKey(true).KeyChar);
                if (answer == 'y')
                {
                    retry = true;
                }
                if (answer == 'n')
                {
                    retry = false;
                }
            }
        }
    }
}
