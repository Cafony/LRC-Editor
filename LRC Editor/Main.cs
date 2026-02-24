using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyrics_Editor;
using NAudio.Wave;

namespace LRC_Editor
{
    public partial class Main : Form
    {
        private Mp3Player player = new Mp3Player();
        private string loadedFile = null;
        private Timer playbackTimer = new Timer();
        private bool isDragging = false;
        private UndoManager _undoManager;

        public Main()
        {
            InitializeComponent();
            playbackTimer.Interval = 200;
            playbackTimer.Tick += PlaybackTimer_Tick;
            //loadedFile = @"C:\Users\tozec\Music\Estudar\agua.mp3";
            this.KeyPreview = true;
            // Mando o richtext para a class
            _undoManager = new UndoManager(richTextBox1);


        }

        private void PlaybackTimer_Tick(object sender, EventArgs e)
        {
            if (player.IsPlaying && !isDragging)
            {
                int currentSeconds = (int)player.CurrentTime.TotalSeconds;

                if (currentSeconds <= trackBar1.Maximum)
                    trackBar1.Value = currentSeconds;
                labelTime.Text = player.CurrentTime.ToString(@"mm\:ss") + " / " + player.TotalTime.ToString(@"mm\:ss");
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();            
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            player.CurrentTime = TimeSpan.FromSeconds(trackBar1.Value);
            isDragging = false;
        }

        #region PLAY BUTTONS
        private string FormatTime(TimeSpan time)
        {
            int minutes = (int)time.TotalMinutes;
            int seconds = time.Seconds;
            int centiseconds = time.Milliseconds / 10;

            return $"{minutes:00}:{seconds:00}.{centiseconds:00}";
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(loadedFile))
            
                    return;

            player.Play(loadedFile);

            trackBar1.Minimum = 0;
            trackBar1.Maximum = (int)player.TotalTime.TotalSeconds;
            trackBar1.Value = 0;
            labelTime.Text = "00:00 / " + player.TotalTime.ToString(@"mm\:ss");
            playbackTimer.Start();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            // reset trackbar and time label
            trackBar1.Value = 0;
            labelTime.Text = "00:00 / 00:00";
            playbackTimer.Stop();

        }
        private void buttonRewind_Click(object sender, EventArgs e)
        {
            player.Rewind(TimeSpan.FromSeconds(2));
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            player.Forward(TimeSpan.FromSeconds(2));
        }

        #endregion

        #region FORM KEYDOWN
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                InsertTimestamp();
                //e.Handled = true;
                //e.SuppressKeyPress = true;
            }

            if(e.KeyCode == Keys.F3)
            {
                player.Rewind(TimeSpan.FromSeconds(2));
            }

            if(e.KeyCode == Keys.F4)
            {
                player.Forward(TimeSpan.FromSeconds(2));
            }

            if(e.KeyCode == Keys.F5)
            {
                _undoManager.Undo();
            }

            if(e.KeyCode == Keys.F6)
            {
                _undoManager.Redo();
            }
        }

        private void InsertTimestamp()
        {
            
            if (!player.IsPlaying)
                return;

            if(richTextBox1.Lines.Length == 0)
            {
                // If no lines, just insert timestamp at the end to prevent error on insert stamp at line 0
                richTextBox1.Text = " ";                
            }
            // Format time as [mm:ss.ff] for LRC
            string timestamp = $"[{player.CurrentTime.Minutes:D2}:{player.CurrentTime.Seconds:D2}.{player.CurrentTime.Milliseconds / 10:D2}]";

            // Get current line index from caret position
            int caretIndex = richTextBox1.SelectionStart;
            int lineIndex = richTextBox1.GetLineFromCharIndex(caretIndex);

            // Get start index of that line
            int lineStart = richTextBox1.GetFirstCharIndexFromLine(lineIndex);

            // Get current line text
            string lineText = richTextBox1.Lines[lineIndex];

            // If the line starts with a timestamp, remove it
            if (lineText.StartsWith("["))
            {
                // delete line before "]"
                int endBracket = lineText.IndexOf(']');
                if (endBracket != -1) // make sure there is a closing bracket
                {
                    // Remove the old timestamp including the closing bracket
                    richTextBox1.Text = richTextBox1.Text.Remove(lineStart, endBracket + 1);
                }
            }


            // Insert timestamp at start of the line
            richTextBox1.Text = richTextBox1.Text.Insert(lineStart, timestamp + ' ');

            // Move caret to start of next line (or end if last line)
            if (lineIndex < richTextBox1.Lines.Length - 1)
            {
                int nextLineStart = richTextBox1.GetFirstCharIndexFromLine(lineIndex + 1);
                richTextBox1.SelectionStart = nextLineStart;
            }
            else
            {
                // If last line, append a new line
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
            }

            //richTextBox1.ScrollToCaret();
        }
                
        #endregion

        #region MENU TOP
        private void loadMusicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 Files|*.mp3";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadedFile = ofd.FileName;

            }
        }
        private void loadLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|Lyrics (*.lrc)|*.lrc|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(filePath);

                    richTextBox1.Text = fileContent; // show the text, not the path
                }
            }
        }
        private void saveLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Lyrics Files (*.lrc)|*.lrc|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.Title = "Save Text File";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, richTextBox1.Text);
                    MessageBox.Show("File saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }
        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        #endregion

    }
}
