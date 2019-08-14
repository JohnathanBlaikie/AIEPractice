using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTests
{
    class Television
    {
        //public bool volUp, volDown;
        private int currentChannel;
        private int currentVolume;

        // increases the volume by one
        public void increaseVolume()
        {
            currentVolume++;
        }

        // decreases the volume by one
        public void decreaseVolume()
        {
            currentVolume--;
        }

        // // returns the current volume
        public int volume()
        {
            return currentVolume;
        }

        // increases the channel num by one
        public void increaseChannel()
        {
            currentChannel++;
        }

        // decreases the channel num by one
        public void decreaseChannel()
        {
            currentChannel--;
        }

        // returns the current channel
        public int channel()
        {
            return currentChannel;
        }
        public void desplayChannel()
        {
            //channel = currentChannel;
            Console.WriteLine(currentChannel);
        }
        static void Main(string[] args)
        {
            char userInput = 'x';
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
