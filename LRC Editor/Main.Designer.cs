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
            this.loadTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllSyncronizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseSentenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatSpacesToOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.checkBoxSpeed = new System.Windows.Forms.CheckBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.buttonCopyText = new System.Windows.Forms.Button();
            this.buttonPasteText = new System.Windows.Forms.Button();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.volumeTrackbar = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.buttonSync = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMusicToolStripMenuItem1,
            this.toolStripSeparator1,
            this.loadTextToolStripMenuItem,
            this.loadLyricsToolStripMenuItem,
            this.saveLyricsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadMusicToolStripMenuItem1
            // 
            this.loadMusicToolStripMenuItem1.Name = "loadMusicToolStripMenuItem1";
            this.loadMusicToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadMusicToolStripMenuItem1.Text = "Load Music";
            this.loadMusicToolStripMenuItem1.Click += new System.EventHandler(this.loadMusicToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // loadTextToolStripMenuItem
            // 
            this.loadTextToolStripMenuItem.Name = "loadTextToolStripMenuItem";
            this.loadTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadTextToolStripMenuItem.Text = "Load Text";
            this.loadTextToolStripMenuItem.Click += new System.EventHandler(this.loadTextToolStripMenuItem_Click);
            // 
            // loadLyricsToolStripMenuItem
            // 
            this.loadLyricsToolStripMenuItem.Name = "loadLyricsToolStripMenuItem";
            this.loadLyricsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadLyricsToolStripMenuItem.Text = "Load Lyrics";
            this.loadLyricsToolStripMenuItem.Click += new System.EventHandler(this.loadLyricsToolStripMenuItem_Click);
            // 
            // saveLyricsToolStripMenuItem
            // 
            this.saveLyricsToolStripMenuItem.Name = "saveLyricsToolStripMenuItem";
            this.saveLyricsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveLyricsToolStripMenuItem.Text = "Save Lyrics";
            this.saveLyricsToolStripMenuItem.Click += new System.EventHandler(this.saveLyricsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTextToolStripMenuItem,
            this.deleteAllSyncronizationToolStripMenuItem,
            this.caseSentenceToolStripMenuItem,
            this.formatSpacesToOneToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.clearTextToolStripMenuItem.Text = "Clear Text";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // deleteAllSyncronizationToolStripMenuItem
            // 
            this.deleteAllSyncronizationToolStripMenuItem.Name = "deleteAllSyncronizationToolStripMenuItem";
            this.deleteAllSyncronizationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.deleteAllSyncronizationToolStripMenuItem.Text = "Delete All Syncronization";
            this.deleteAllSyncronizationToolStripMenuItem.Click += new System.EventHandler(this.deleteAllSyncronizationToolStripMenuItem_Click);
            // 
            // caseSentenceToolStripMenuItem
            // 
            this.caseSentenceToolStripMenuItem.Name = "caseSentenceToolStripMenuItem";
            this.caseSentenceToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.caseSentenceToolStripMenuItem.Text = "Case Sentence";
            this.caseSentenceToolStripMenuItem.Click += new System.EventHandler(this.caseSentenceToolStripMenuItem_Click);
            // 
            // formatSpacesToOneToolStripMenuItem
            // 
            this.formatSpacesToOneToolStripMenuItem.Name = "formatSpacesToOneToolStripMenuItem";
            this.formatSpacesToOneToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.formatSpacesToOneToolStripMenuItem.Text = "Format spaces to one";
            this.formatSpacesToOneToolStripMenuItem.ToolTipText = "Make all spaces on text equal to one";
            this.formatSpacesToOneToolStripMenuItem.Click += new System.EventHandler(this.formatSpacesToOneToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlay.Location = new System.Drawing.Point(283, 637);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(81, 35);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play F8";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(18, 558);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(948, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStop.Location = new System.Drawing.Point(372, 637);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(76, 35);
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
            this.labelTime.Location = new System.Drawing.Point(624, 637);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.richTextBox1.Location = new System.Drawing.Point(18, 86);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(946, 461);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // buttonRewind
            // 
            this.buttonRewind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRewind.Location = new System.Drawing.Point(456, 637);
            this.buttonRewind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(75, 35);
            this.buttonRewind.TabIndex = 7;
            this.buttonRewind.Text = "<< F6";
            this.toolTip1.SetToolTip(this.buttonRewind, "Rewind F3");
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonForward.Location = new System.Drawing.Point(540, 637);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(75, 35);
            this.buttonForward.TabIndex = 8;
            this.buttonForward.Text = "F7 >>";
            this.toolTip1.SetToolTip(this.buttonForward, "Forward F4");
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUndo.Location = new System.Drawing.Point(830, 42);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(62, 35);
            this.buttonUndo.TabIndex = 9;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedo.Location = new System.Drawing.Point(901, 42);
            this.buttonRedo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(62, 35);
            this.buttonRedo.TabIndex = 10;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // checkBoxSpeed
            // 
            this.checkBoxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSpeed.AutoSize = true;
            this.checkBoxSpeed.Location = new System.Drawing.Point(22, 645);
            this.checkBoxSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSpeed.Name = "checkBoxSpeed";
            this.checkBoxSpeed.Size = new System.Drawing.Size(95, 24);
            this.checkBoxSpeed.TabIndex = 11;
            this.checkBoxSpeed.Text = "Speed 2x";
            this.checkBoxSpeed.UseVisualStyleBackColor = true;
            this.checkBoxSpeed.CheckedChanged += new System.EventHandler(this.checkBoxSpeed_CheckedChanged);
            // 
            // labelFilename
            // 
            this.labelFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(18, 608);
            this.labelFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(118, 20);
            this.labelFilename.TabIndex = 12;
            this.labelFilename.Text = "MP3 Filename: ";
            // 
            // buttonCopyText
            // 
            this.buttonCopyText.Location = new System.Drawing.Point(22, 42);
            this.buttonCopyText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCopyText.Name = "buttonCopyText";
            this.buttonCopyText.Size = new System.Drawing.Size(99, 35);
            this.buttonCopyText.TabIndex = 13;
            this.buttonCopyText.Text = "Copy Text";
            this.buttonCopyText.UseVisualStyleBackColor = true;
            this.buttonCopyText.Click += new System.EventHandler(this.buttonCopyText_Click);
            // 
            // buttonPasteText
            // 
            this.buttonPasteText.Location = new System.Drawing.Point(130, 42);
            this.buttonPasteText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPasteText.Name = "buttonPasteText";
            this.buttonPasteText.Size = new System.Drawing.Size(99, 35);
            this.buttonPasteText.TabIndex = 14;
            this.buttonPasteText.Text = "Paste Text";
            this.buttonPasteText.UseVisualStyleBackColor = true;
            this.buttonPasteText.Click += new System.EventHandler(this.buttonPasteText_Click);
            // 
            // buttonClearText
            // 
            this.buttonClearText.Location = new System.Drawing.Point(238, 42);
            this.buttonClearText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(99, 35);
            this.buttonClearText.TabIndex = 15;
            this.buttonClearText.Text = "Clear Text";
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // volumeTrackbar
            // 
            this.volumeTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackbar.LargeChange = 10;
            this.volumeTrackbar.Location = new System.Drawing.Point(736, 637);
            this.volumeTrackbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volumeTrackbar.Maximum = 100;
            this.volumeTrackbar.Name = "volumeTrackbar";
            this.volumeTrackbar.Size = new System.Drawing.Size(156, 45);
            this.volumeTrackbar.SmallChange = 5;
            this.volumeTrackbar.TabIndex = 16;
            this.volumeTrackbar.Value = 10;
            this.volumeTrackbar.Scroll += new System.EventHandler(this.volumeTrackbar_Scroll);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(896, 640);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(63, 20);
            this.labelVolume.TabIndex = 17;
            this.labelVolume.Text = "Volume";
            // 
            // buttonSync
            // 
            this.buttonSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSync.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSync.Location = new System.Drawing.Point(148, 637);
            this.buttonSync.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(81, 35);
            this.buttonSync.TabIndex = 18;
            this.buttonSync.Text = "Sync F2";
            this.buttonSync.UseVisualStyleBackColor = false;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.volumeTrackbar);
            this.Controls.Add(this.buttonClearText);
            this.Controls.Add(this.buttonPasteText);
            this.Controls.Add(this.buttonCopyText);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.checkBoxSpeed);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonRewind);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 730);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lyrics Subtitle Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem caseSentenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatSpacesToOneToolStripMenuItem;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.CheckBox checkBoxSpeed;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Button buttonCopyText;
        private System.Windows.Forms.Button buttonPasteText;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.TrackBar volumeTrackbar;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Button buttonSync;
    }
}

