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

namespace TuneStore
{
    public partial class Form1 : Form
    {
        int nr = 0;

        SongClass[] obSong = new SongClass[100];    

        System.Media.SoundPlayer player =
        new System.Media.SoundPlayer();
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashscreen));
            t.Start();
            Thread.Sleep(7000);
            InitializeComponent();
            t.Abort();
        }

        public void splashscreen()
        {
            Application.Run(new splashscreen());
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        private void stopSound( )
        {
            player.Stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tbSong.Text = comboBox1.Text;
            playSound(tbSong.Text);
            string FileName = System.IO.Path.GetFileName(tbSong.Text);
            int index2 = FileName.IndexOf('.');
            string TuneName = FileName.Substring(0, index2);
            tbTuneName.Text = TuneName;
           

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
                SaveSongs.WriteLine(obSong[m_nr].SongLocation);
            }
            SaveSongs.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m_FileNameAndLocation;

            OpenFileDialog ofdSongs = new OpenFileDialog();

            ofdSongs.ShowDialog();

            m_FileNameAndLocation = ofdSongs.FileName;

            StreamReader openSongs = new StreamReader(m_FileNameAndLocation, true);

           

            while (openSongs.EndOfStream == false)
            {
                comboBox1.Text = openSongs.ReadLine();
            }

            openSongs.Close();
        }
    }
}
