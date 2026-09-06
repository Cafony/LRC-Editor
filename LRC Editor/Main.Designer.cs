namespace LRC_Editor
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMusicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllSyncronizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractLyricsFromMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f2SyncInsertTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f6RewindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f7ForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f3UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fRedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f8PauseMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMusicToolStripMenuItem1,
            this.toolStripSeparator1,
            this.loadLyricsToolStripMenuItem,
            this.saveLyricsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadMusicToolStripMenuItem1
            // 
            this.loadMusicToolStripMenuItem1.Name = "loadMusicToolStripMenuItem1";
            this.loadMusicToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.loadMusicToolStripMenuItem1.Text = "Load Music";
            this.loadMusicToolStripMenuItem1.Click += new System.EventHandler(this.loadMusicToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // loadLyricsToolStripMenuItem
            // 
            this.loadLyricsToolStripMenuItem.Name = "loadLyricsToolStripMenuItem";
            this.loadLyricsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadLyricsToolStripMenuItem.Text = "Load Lyrics";
            this.loadLyricsToolStripMenuItem.Click += new System.EventHandler(this.loadLyricsToolStripMenuItem_Click);
            // 
            // saveLyricsToolStripMenuItem
            // 
            this.saveLyricsToolStripMenuItem.Name = "saveLyricsToolStripMenuItem";
            this.saveLyricsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveLyricsToolStripMenuItem.Text = "Save Lyrics";
            this.saveLyricsToolStripMenuItem.Click += new System.EventHandler(this.saveLyricsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTextToolStripMenuItem,
            this.deleteAllSyncronizationToolStripMenuItem,
            this.extractLyricsFromMusicToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.clearTextToolStripMenuItem.Text = "Clear Text";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // deleteAllSyncronizationToolStripMenuItem
            // 
            this.deleteAllSyncronizationToolStripMenuItem.Name = "deleteAllSyncronizationToolStripMenuItem";
            this.deleteAllSyncronizationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.deleteAllSyncronizationToolStripMenuItem.Text = "Delete All Syncronization";
            this.deleteAllSyncronizationToolStripMenuItem.Click += new System.EventHandler(this.deleteAllSyncronizationToolStripMenuItem_Click);
            // 
            // extractLyricsFromMusicToolStripMenuItem
            // 
            this.extractLyricsFromMusicToolStripMenuItem.Name = "extractLyricsFromMusicToolStripMenuItem";
            this.extractLyricsFromMusicToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.extractLyricsFromMusicToolStripMenuItem.Text = "Extract Lyrics from Music";
            this.extractLyricsFromMusicToolStripMenuItem.Click += new System.EventHandler(this.extractLyricsFromMusicToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f2SyncInsertTimeToolStripMenuItem,
            this.f6RewindToolStripMenuItem,
            this.f7ForwardToolStripMenuItem,
            this.f3UndoToolStripMenuItem,
            this.fRedoToolStripMenuItem,
            this.f8PauseMusicToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // f2SyncInsertTimeToolStripMenuItem
            // 
            this.f2SyncInsertTimeToolStripMenuItem.Name = "f2SyncInsertTimeToolStripMenuItem";
            this.f2SyncInsertTimeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.f2SyncInsertTimeToolStripMenuItem.Text = "F2 - Sync Insert Time";
            // 
            // f6RewindToolStripMenuItem
            // 
            this.f6RewindToolStripMenuItem.Name = "f6RewindToolStripMenuItem";
            this.f6RewindToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.f6RewindToolStripMenuItem.Text = "F6 - Rewind";
            // 
            // f7ForwardToolStripMenuItem
            // 
            this.f7ForwardToolStripMenuItem.Name = "f7ForwardToolStripMenuItem";
            this.f7ForwardToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.f7ForwardToolStripMenuItem.Text = "F7 - Forward";
            // 
            // f3UndoToolStripMenuItem
            // 
            this.f3UndoToolStripMenuItem.Name = "f3UndoToolStripMenuItem";
            this.f3UndoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.f3UndoToolStripMenuItem.Text = "F3 - Undo";
            // 
            // fRedoToolStripMenuItem
            // 
            this.fRedoToolStripMenuItem.Name = "fRedoToolStripMenuItem";
            this.fRedoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fRedoToolStripMenuItem.Text = "F4 - Redo";
            // 
            // f8PauseMusicToolStripMenuItem
            // 
            this.f8PauseMusicToolStripMenuItem.Name = "f8PauseMusicToolStripMenuItem";
            this.f8PauseMusicToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.f8PauseMusicToolStripMenuItem.Text = "F8 - Pause Music";
            this.f8PauseMusicToolStripMenuItem.Click += new System.EventHandler(this.f8PauseMusicToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlay.Location = new System.Drawing.Point(127, 479);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(90, 23);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play F8";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(12, 428);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(695, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStop.Location = new System.Drawing.Point(223, 479);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop F9";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(452, 481);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(115, 24);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "00:00 / 00:00";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(695, 395);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // buttonRewind
            // 
            this.buttonRewind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRewind.Location = new System.Drawing.Point(304, 479);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(50, 23);
            this.buttonRewind.TabIndex = 7;
            this.buttonRewind.Text = "<< F6";
            this.toolTip1.SetToolTip(this.buttonRewind, "Rewind F3");
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonForward.Location = new System.Drawing.Point(360, 479);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(50, 23);
            this.buttonForward.TabIndex = 8;
            this.buttonForward.Text = "F7 >>";
            this.toolTip1.SetToolTip(this.buttonForward, "Forward F4");
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 514);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonRewind);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 490);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lyrics Subtitle Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMusicToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadLyricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLyricsToolStripMenuItem;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f2SyncInsertTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f6RewindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f7ForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f3UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fRedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllSyncronizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f8PauseMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractLyricsFromMusicToolStripMenuItem;
    }
}

