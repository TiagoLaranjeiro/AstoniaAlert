using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace Astonia_Alert
{
    class Player
    {
        public void playTrumpet()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.trumpet);
            player.Play();
        }
    }
}
