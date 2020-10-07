using System;
using System.Windows.Forms;

namespace Astonia_Alert
{
    public partial class AstoniaTimer : Form
    {
        // Initializers
        ATimer aTimer = new ATimer();
        Player player = new Player();
        int reseter = 0;
        public AstoniaTimer()
        { 
            InitializeComponent();
            timerDisplay.Text = aTimer.GetTime();
        }

        // Timer (60s)
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayTime();
        }

        // Update timer display and play sound when <= 00:005
        private void displayTime()
        {
            timerDisplay.Text = aTimer.GetTime();
            if ((DateTime.Parse(aTimer.GetTime()) <= DateTime.Parse("00:05")) && reseter == 0)
            {
                timerDisplay.Refresh();
                player.playTrumpet();
                reseter = 1;
            }
            else if ((DateTime.Parse(aTimer.GetTime()) > DateTime.Parse("00:05") && reseter == 1))
            {
                reseter = 0;
            }
            timerDisplay.Refresh();
        }
    }
}