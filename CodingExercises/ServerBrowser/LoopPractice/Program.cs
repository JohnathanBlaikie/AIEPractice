using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 101; counter++)
            {
                Console.WriteLine($"the For loop is currently at {counter}");
            }

            Console.ReadKey();
        }
    }
}
