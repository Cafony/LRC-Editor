using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace LRC_Editor
{
    internal class Mp3Player
    {
        private IWavePlayer outputDevice;
        private AudioFileReader audioFile;

        public bool IsPlaying => outputDevice?.PlaybackState == PlaybackState.Playing;

        public void Play(string filePath)
        {

            Stop();

            audioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();

        }

        public void Pause()
        {
            if (outputDevice?.PlaybackState == PlaybackState.Playing)
                outputDevice.Pause();
        }

        public void Resume()
        {
            if (outputDevice?.PlaybackState == PlaybackState.Paused)
                outputDevice.Play();
        }

        public void Stop()
        {
            outputDevice?.Stop();
            audioFile?.Dispose();
            outputDevice?.Dispose();

            audioFile = null;
            outputDevice = null;
        }


        public TimeSpan CurrentTime
        {
            get => audioFile?.CurrentTime ?? TimeSpan.Zero;
            set
            {
                if (audioFile != null)
                    audioFile.CurrentTime = value;
            }
        }

        public void Forward(TimeSpan interval)
        {
            if (audioFile != null)
            {
                var newTime = CurrentTime + interval;
                if (newTime > TotalTime)
                    newTime = TotalTime;
                CurrentTime = newTime;
            }
        }

        public void Rewind(TimeSpan interval)
        {
            if (audioFile != null)
            {
                var newTime = CurrentTime - interval;
                if (newTime < TimeSpan.Zero)
                    newTime = TimeSpan.Zero;
                CurrentTime = newTime;
            }
        }


        public TimeSpan TotalTime => audioFile?.TotalTime ?? TimeSpan.Zero;

        public float Volume
        {
            get => audioFile?.Volume ?? 0f;
            set
            {
                if (audioFile != null)
                    audioFile.Volume = value;
            }
        }

        public void Dispose()
        {
            Stop();
        }

    }
}
