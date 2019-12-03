using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractice
{
    class Program
    {
        MyRandom r = new MyRandom();
        static void Main(string[] args)
        {
            bool loop = true;

            while(loop)
            {
                Console.WriteLine("Please Select An Exercise:");
                Console.WriteLine("[1] Random Angle in a 2D Circle" +
                    "\n [2] Random Point in a 3D Sphere");
                int.TryParse(Console.ReadLine(), out int bruh);
                if(bruh == 1)
                {
                    float x, y, z;
                }
            }
            
        }


    }
    class MyRandom
    {
        //public float x, y, z;
        public MyRandom(float x, float y, float z)
        {

        }
        public MyRandom()
        {

        }


    }
   
}
