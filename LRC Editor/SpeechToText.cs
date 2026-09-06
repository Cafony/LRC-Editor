using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Vosk;

namespace LRC_Editor
{
    public class SpeechToText
    {
        private Model _model;

        public SpeechToText(string modelPath)
        {
            if (!Directory.Exists(modelPath))
            {
                throw new DirectoryNotFoundException(
                    "Vosk model not found: " + modelPath);
            }

            Vosk.Vosk.SetLogLevel(0);

            _model = new Model(modelPath);
        }

        public string Convert(string wavFile)
        {
            if (!File.Exists(wavFile))
            {
                throw new FileNotFoundException(
                    "Audio file not found.",
                    wavFile);
            }

            StringBuilder result = new StringBuilder();

            using (VoskRecognizer recognizer =
                   new VoskRecognizer(_model, 16000.0f))
            {
                recognizer.SetWords(true);

                using (FileStream audio =
                       File.OpenRead(wavFile))
                {
                    byte[] buffer = new byte[4096];

                    int bytesRead;

                    while ((bytesRead =
                           audio.Read(
                               buffer,
                               0,
                               buffer.Length)) > 0)
                    {
                        recognizer.AcceptWaveform(
                            buffer,
                            bytesRead);
                    }
                }

                string finalResult =
                    recognizer.FinalResult();

                result.Append(
                    ExtractText(finalResult));
            }

            return result.ToString().Trim();
        }

        private string ExtractText(string json)
        {
            try
            {
                using (JsonDocument document =
                       JsonDocument.Parse(json))
                {
                    JsonElement root =
                        document.RootElement;

                    if (root.TryGetProperty(
                        "text",
                        out JsonElement text))
                    {
                        return text.GetString() ?? "";
                    }
                }
            }
            catch
            {
                // Ignore invalid JSON
            }

            return "";
        }

        public void Dispose()
        {
            if (_model != null)
            {
                _model.Dispose();
                _model = null;
            }
        }
    }
}
