using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TuneStore
{
    public partial class splashscreen : Form
    {
      
        public splashscreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = @"C:\games\download\muziek\ERA_-_Ameno.wav";
            //player.Load();
            //player.Play();
            if (progressBar1.Value > 90)
            {
                player.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }
    }
}
