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
        int genericTimeS = 300; // 300 s = 5 minutes

        public Form1()
        {
            InitializeComponent();

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == _buttonPause)
            {
                pictureBox1.Image = _buttonPlay;
            }
            else
            {
                pictureBox1.Image = _buttonPause;
            }
        }

        private void timerDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
