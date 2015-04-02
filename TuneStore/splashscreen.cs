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
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        
        public splashscreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            player.SoundLocation = @"..\..\muziek\darude.wav";
            player.Load();
            player.Play();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            player.Stop();
            timer2.Stop();
        }

        
    }
}
