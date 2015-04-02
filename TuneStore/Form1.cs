using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace TuneStore
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        int nr = 0;
        SongClass[] obSong = new SongClass[100];   
        System.Media.SoundPlayer player =
        new System.Media.SoundPlayer();

        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashscreen));
            t.Start();
            Thread.Sleep(7000);
            t.Abort();
            InitializeComponent();
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackWave.Value = CalcVol / (ushort.MaxValue / 10);
        }

       
        public void splashscreen()
        {
            Application.Run(new splashscreen());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Addmethod();
        }

        private void Addmethod()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files (.wav)|*.wav";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string FilenameFull = System.IO.Path.GetFileName(path);
                int index = FilenameFull.IndexOf('.');
                string FileNameWithoutExtension = FilenameFull.Substring(0, index);


                if (comboBox1.Items.Contains(path))
                {
                    MessageBox.Show("this song is already in the list!");
                }
                else
                {
                    rtbTunes.AppendText(path);
                    rtbTunes.AppendText("\n");
                    comboBox1.Items.Add(path);


                    obSong[nr] = new SongClass();
                    obSong[nr].SongLocation = path;
                    obSong[nr].SongName = FileNameWithoutExtension;
                    nr++;

                }
            }
        }

        private void playSound(string path)
        {
            try
            {
                player.SoundLocation = path;
                player.Load();
                player.Play();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please set a song before pressing play", "It was at this moment, we knew, you fucked up.", MessageBoxButtons.OK);
            }
            catch (NullReferenceException)
            {
                    
            }
        }

        private void stopSound( )
        {
            player.Stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                tbSong.Text = comboBox1.Text;
                playSound(tbSong.Text);
                string FileName = System.IO.Path.GetFileName(tbSong.Text);
                int index2 = FileName.IndexOf('.');
                string TuneName = FileName.Substring(0, index2);
                tbTuneName.Text = TuneName;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please set a song before pressing play", "It was at this moment, we knew, you fucked up.", MessageBoxButtons.OK);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopSound();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m_FileNameAndLocation;

            SaveFileDialog sfdSongs = new SaveFileDialog();

            sfdSongs.ShowDialog();

            m_FileNameAndLocation = sfdSongs.FileName;

            StreamWriter SaveSongs = new StreamWriter(m_FileNameAndLocation);


            for (int m_nr = 0; m_nr < nr; m_nr++)
            {
                SaveSongs.WriteLine(obSong[m_nr].SongName);
                SaveSongs.WriteLine(obSong[m_nr].SongLocation);
            }
            SaveSongs.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m_FileNameAndLocation;

            ofdSongs.ShowDialog();
            try
            {
                m_FileNameAndLocation = ofdSongs.FileName;
                StreamReader openSongs = new StreamReader(m_FileNameAndLocation);
                while (openSongs.EndOfStream == false)
                {
                    tbTuneName.Text = openSongs.ReadLine();
                    tbTuneLocation.Text = openSongs.ReadLine();
                    comboBox1.Items.Add(tbTuneLocation.Text);
                    rtbTunes.AppendText(tbTuneLocation.Text);
                    rtbTunes.AppendText("\n");
                    tbTuneLocation.Text = "tune location";
                    tbTuneName.Text = "tune name";
                }
                openSongs.Close();
            }
            catch (FileNotFoundException)
            {
                
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         int NewVolume = ((ushort.MaxValue / 10) * trackWave.Value);
         uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
         waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string file = comboBox1.Text;
            int index2 = file.IndexOf('.');
            string TuneName = file.Substring(0, index2);
            tbSong.Text = comboBox1.Text;
            tbTuneName.Text = TuneName;
            tbTuneLocation.Text = comboBox1.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
