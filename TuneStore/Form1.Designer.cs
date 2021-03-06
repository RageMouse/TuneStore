﻿namespace TuneStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbOverlay = new System.Windows.Forms.GroupBox();
            this.trackWave = new System.Windows.Forms.TrackBar();
            this.lbltuneposition = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbTunes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSong = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.tbTuneLocation = new System.Windows.Forms.TextBox();
            this.tbTuneName = new System.Windows.Forms.TextBox();
            this.sfdSaveAs = new System.Windows.Forms.SaveFileDialog();
            this.ofdSongs = new System.Windows.Forms.OpenFileDialog();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tSToolStripMenuItem
            // 
            this.tSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.tSToolStripMenuItem.Name = "tSToolStripMenuItem";
            this.tSToolStripMenuItem.Size = new System.Drawing.Size(34, 21);
            this.tSToolStripMenuItem.Text = "TS";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.playlistToolStripMenuItem.Text = "Playlist.";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.playlistsToolStripMenuItem.Text = "Playlists.";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultStockToolStripMenuItem,
            this.clearDefaultToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // loadDefaultStockToolStripMenuItem
            // 
            this.loadDefaultStockToolStripMenuItem.Name = "loadDefaultStockToolStripMenuItem";
            this.loadDefaultStockToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadDefaultStockToolStripMenuItem.Text = "Load Default Stock.";
            // 
            // clearDefaultToolStripMenuItem
            // 
            this.clearDefaultToolStripMenuItem.Name = "clearDefaultToolStripMenuItem";
            this.clearDefaultToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.clearDefaultToolStripMenuItem.Text = "Clear Default.";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About.";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.helpToolStripMenuItem1.Text = "Help.";
            // 
            // gbOverlay
            // 
            this.gbOverlay.Controls.Add(this.trackWave);
            this.gbOverlay.Controls.Add(this.lbltuneposition);
            this.gbOverlay.Controls.Add(this.textBox1);
            this.gbOverlay.Controls.Add(this.btnSearch);
            this.gbOverlay.Controls.Add(this.btnStop);
            this.gbOverlay.Controls.Add(this.label5);
            this.gbOverlay.Controls.Add(this.label3);
            this.gbOverlay.Controls.Add(this.comboBox1);
            this.gbOverlay.Controls.Add(this.label2);
            this.gbOverlay.Controls.Add(this.rtbTunes);
            this.gbOverlay.Controls.Add(this.btnPlay);
            this.gbOverlay.Controls.Add(this.label1);
            this.gbOverlay.Controls.Add(this.tbSong);
            this.gbOverlay.Controls.Add(this.btnAdd);
            this.gbOverlay.Controls.Add(this.btnSet);
            this.gbOverlay.Controls.Add(this.tbTuneLocation);
            this.gbOverlay.Controls.Add(this.tbTuneName);
            this.gbOverlay.Location = new System.Drawing.Point(13, 29);
            this.gbOverlay.Name = "gbOverlay";
            this.gbOverlay.Size = new System.Drawing.Size(471, 389);
            this.gbOverlay.TabIndex = 1;
            this.gbOverlay.TabStop = false;
            // 
            // trackWave
            // 
            this.trackWave.Location = new System.Drawing.Point(329, 126);
            this.trackWave.Name = "trackWave";
            this.trackWave.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackWave.Size = new System.Drawing.Size(45, 183);
            this.trackWave.TabIndex = 18;
            this.trackWave.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbltuneposition
            // 
            this.lbltuneposition.AutoSize = true;
            this.lbltuneposition.Location = new System.Drawing.Point(786, 389);
            this.lbltuneposition.Name = "lbltuneposition";
            this.lbltuneposition.Size = new System.Drawing.Size(0, 13);
            this.lbltuneposition.TabIndex = 17;
            this.lbltuneposition.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 327);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search.";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "... Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "List:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tunes in stock.";
            // 
            // rtbTunes
            // 
            this.rtbTunes.Location = new System.Drawing.Point(9, 126);
            this.rtbTunes.Name = "rtbTunes";
            this.rtbTunes.ReadOnly = true;
            this.rtbTunes.Size = new System.Drawing.Size(311, 183);
            this.rtbTunes.TabIndex = 7;
            this.rtbTunes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Selection.";
            // 
            // tbSong
            // 
            this.tbSong.Location = new System.Drawing.Point(9, 86);
            this.tbSong.Name = "tbSong";
            this.tbSong.Size = new System.Drawing.Size(210, 20);
            this.tbSong.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(225, 44);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(113, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tbTuneLocation
            // 
            this.tbTuneLocation.Location = new System.Drawing.Point(9, 47);
            this.tbTuneLocation.Name = "tbTuneLocation";
            this.tbTuneLocation.ReadOnly = true;
            this.tbTuneLocation.Size = new System.Drawing.Size(210, 20);
            this.tbTuneLocation.TabIndex = 1;
            this.tbTuneLocation.Text = "Tune Location.";
            // 
            // tbTuneName
            // 
            this.tbTuneName.Location = new System.Drawing.Point(9, 20);
            this.tbTuneName.Name = "tbTuneName";
            this.tbTuneName.ReadOnly = true;
            this.tbTuneName.Size = new System.Drawing.Size(453, 20);
            this.tbTuneName.TabIndex = 0;
            this.tbTuneName.Text = "Tune Name.";
            // 
            // ofdSongs
            // 
            this.ofdSongs.FileName = "openFileDialog1";
            // 
            // btnStop
            // 
            this.btnStop.Image = global::TuneStore.Properties.Resources._9iRR9b54T6;
            this.btnStop.Location = new System.Drawing.Point(400, 314);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 62);
            this.btnStop.TabIndex = 14;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::TuneStore.Properties.Resources._9iRR9b54T3;
            this.btnPlay.Location = new System.Drawing.Point(329, 314);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(65, 62);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(495, 427);
            this.Controls.Add(this.gbOverlay);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TuneStore";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbOverlay.ResumeLayout(false);
            this.gbOverlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbOverlay;
        private System.Windows.Forms.TextBox tbTuneName;
        private System.Windows.Forms.TextBox tbTuneLocation;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbTunes;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog sfdSaveAs;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.OpenFileDialog ofdSongs;
        private System.Windows.Forms.Label lbltuneposition;
        private System.Windows.Forms.TrackBar trackWave;
    }
}

