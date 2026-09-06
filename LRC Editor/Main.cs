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
        private Mp3Player _player = new Mp3Player();
        private string loadedMp3File = null;
        private Timer playbackTimer = new Timer();
        private bool isDragging = false;
        private UndoManager _undoManager;
        private bool isPaused = false;
        private string _waveFile;

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
            if (_player.IsPlaying && !isDragging)
            {
                int currentSeconds = (int)_player.CurrentTime.TotalSeconds;

                if (currentSeconds <= trackBar1.Maximum)
                    trackBar1.Value = currentSeconds;
                labelTime.Text = _player.CurrentTime.ToString(@"mm\:ss") + " / " + _player.TotalTime.ToString(@"mm\:ss");
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _player.Stop();            
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            _player.CurrentTime = TimeSpan.FromSeconds(trackBar1.Value);
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

        private void PlayMusic()
        {
            if (_player.IsPlaying)
            {
                // Currently playing → pause
                _player.Pause();
                isPaused = true;
                playbackTimer.Stop();
                buttonPlay.Text = "Pause F8";
                buttonPlay.BackColor = Color.White;

            }
            else if (isPaused)
            {
                // Currently paused → resume
                _player.Resume();
                isPaused = false;
                playbackTimer.Start();
                buttonPlay.Text = "Play F8";
                buttonPlay.BackColor = Color.Green;

            }
            else
            {
                // Nothing playing → start the MP3
                _player.Play(loadedMp3File);
                isPaused = false;

                trackBar1.Minimum = 0;
                trackBar1.Maximum = (int)_player.TotalTime.TotalSeconds;
                trackBar1.Value = 0;

                labelTime.Text = "00:00 / " +
                    _player.TotalTime.ToString(@"mm\:ss");

                playbackTimer.Start();
                buttonPlay.BackColor = Color.Green;

            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loadedMp3File))
            {
                MessageBox.Show("No mp3 file loaded");
                return;
            }

            PlayMusic();

        }

        private void StopMusic()
        {
            _player.Stop();
            // reset trackbar and time label
            trackBar1.Value = 0;
            labelTime.Text = "00:00 / 00:00";
            playbackTimer.Stop();
            buttonPlay.UseVisualStyleBackColor = true;
            isPaused = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopMusic();
        }

        public void PlayForward()
        {
            _player.Forward(TimeSpan.FromSeconds(2));
            int currentSeconds = (int)_player.CurrentTime.TotalSeconds;

            if (currentSeconds <= trackBar1.Maximum)
                trackBar1.Value = currentSeconds;
            labelTime.Text = _player.CurrentTime.ToString(@"mm\:ss") + " / " + _player.TotalTime.ToString(@"mm\:ss");
        }

        public void PlayBackward()
        {
            _player.Rewind(TimeSpan.FromSeconds(2));
            int currentSeconds = (int)_player.CurrentTime.TotalSeconds;

            if (currentSeconds <= trackBar1.Maximum)
                trackBar1.Value = currentSeconds;
            labelTime.Text = _player.CurrentTime.ToString(@"mm\:ss") + " / " + _player.TotalTime.ToString(@"mm\:ss");
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            PlayBackward();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            PlayForward();
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
                _undoManager.Undo();
            }

            if(e.KeyCode == Keys.F4)
            {
                _undoManager.Redo();
            }


            if(e.KeyCode == Keys.F6)
            {
                PlayBackward();
            }
            if(e.KeyCode == Keys.F7)
            {
                PlayForward();
            }


            if(e.KeyCode == Keys.F8)
            {
                PlayMusic();
            }

            if (e.KeyCode == Keys.F9)
            {
                StopMusic();
            }

        }

        private void InsertTimestamp()
        {
            
            if (!_player.IsPlaying)
                return;

            if(richTextBox1.Lines.Length == 0)
            {
                // If no lines, just insert timestamp at the end to prevent error on insert stamp at line 0
                richTextBox1.Text = " ";                
            }
            // Format time as [mm:ss.ff] for LRC
            string timestamp = $"[{_player.CurrentTime.Minutes:D2}:{_player.CurrentTime.Seconds:D2}.{_player.CurrentTime.Milliseconds / 10:D2}]";

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
                loadedMp3File = ofd.FileName;

            }

            _waveFile = Path.Combine(
            Path.GetTempPath(),
            Guid.NewGuid().ToString() + ".wav");

        }
        private void loadLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // open txt files and lrc files
                openFileDialog.Filter = "Lyrics Files (*.lrc;*.txt)|*.lrc;*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    //string fileContent = File.ReadAllText(filePath, Encoding.GetEncoding("iso-8859-1"));
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
                    System.IO.File.WriteAllText(sfd.FileName, richTextBox1.Text, Encoding.GetEncoding(1252));
                    //System.IO.File.WriteAllText(sfd.FileName, richTextBox1.Text);
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

        private void deleteAllSyncronizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if RichTextBox is empty
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
                return;

            string[] lines = richTextBox1.Lines;

            for (int i = 0; i < lines.Length; i++)
            {
                int index = lines[i].IndexOf(']');

                if (index >= 0)
                {
                    // Remove everything before and including ']'
                    lines[i] = lines[i].Substring(index + 1);
                }
            }

            richTextBox1.Lines = lines;
        }

        private void f8PauseMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _player.Pause();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _player.Pause();
        }



        #region Convert Audio to Text
        private void extractLyricsFromMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                try
                {
                    // THIS CALLS THE METHOD
                    ConvertMp3ToWav(
                        loadedMp3File,
                        _waveFile);

                string modelPath = @"C:\Users\tozec\source\repos\LRC Editor\LRC Editor\bin\Debug\vosk-model-small-pt-0.3";


                SpeechToText speech =
                        new SpeechToText(modelPath);

                    string text =
                        speech.Convert(_waveFile);

                    richTextBox1.Text = text;

                    speech.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Speech to Text",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    if (File.Exists(_waveFile))
                    {
                        File.Delete(_waveFile);
                    }
                }
        }
            
        

        private void ConvertMp3ToWav(string mp3File,string wavFile)
        {
            using (var reader =
                   new NAudio.Wave.MediaFoundationReader(mp3File))
            {
                var targetFormat =
                    new NAudio.Wave.WaveFormat(
                        16000,
                        16,
                        1);

                using (var resampler =
                       new NAudio.Wave.MediaFoundationResampler(
                           reader,
                           targetFormat))
                {
                    resampler.ResamplerQuality = 60;

                    NAudio.Wave.WaveFileWriter.CreateWaveFile(
                        wavFile,
                        resampler);
                }
            }
        }

        #endregion
    }

}
