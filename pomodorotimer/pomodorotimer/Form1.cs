using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodorotimer
{
    public partial class Form1 : Form
    {
        // button icons
        Bitmap _buttonPlay = pomodorotimer.Properties.Resources.ButtonPlay;
        Bitmap _buttonPause = pomodorotimer.Properties.Resources.ButtonPause;

        // timer values
        int timerDuration = 300; // 300 seconds = 5 minutes
        int? timeLeft = null;

        public Form1()
        {
            InitializeComponent();

        }
        

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            // if paused, play and switch button to pause, otherwise vice versa
            if (playPauseButton.Image == _buttonPause)
            {
                playPauseButton.Image = _buttonPlay;
                alarmTimer.Stop();

            }
            else
            {
                playPauseButton.Image = _buttonPause;
                alarmTimer.Start();
                if (timeLeft != null)
                {
                    updateTime();
                    return;
                }
                timeLeft = timerDuration;
                updateTime();
            }
        }

        private void timerDisplay_Click(object sender, EventArgs e)
        {

        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                Close();
            }
            else
            {
                timeLeft = timeLeft - 1;
                updateTime();
            }
        }

        private void updateTime()
        {
            if (timeLeft % 60 < 10)
            {
                timerDisplay.Text = timeLeft / 60 + ":0" + timeLeft % 60;
                return;
            }
            timerDisplay.Text = timeLeft / 60 + ":" + timeLeft % 60;
        }

        private void musicChangeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
