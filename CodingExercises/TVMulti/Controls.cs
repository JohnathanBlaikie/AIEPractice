﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
    public class MainControl
    {
        public int currentChannel;
        public int currentVolume;

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
            currentVolume--;
        }

        // returns the current channel
        public int channel()
        {
            return currentChannel;
        }
    }
}

