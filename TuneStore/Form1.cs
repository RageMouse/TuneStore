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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashscreen));
            t.Start();
            Thread.Sleep(5000);
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
                
                if (comboBox1.Items.Contains(path))
                {
                    MessageBox.Show("this song is already in the list!");
                }
                else
                {
                    richTextBox1.AppendText(path);
                    comboBox1.Items.Add(path);
                }
            }
        }

        private void playSound(string path)
        {
            System.Media.SoundPlayer player =
            new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
            playSound(textBox1.Text);
            string fileName = textBox1.Text.Substring(25);
            tbTuneName.Text = fileName;
        }

    }
}
