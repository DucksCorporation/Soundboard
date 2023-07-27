using System.Collections.Generic;
using System.IO;

namespace SoundBoard
{
    public class Sounds : Data
    {
        public Dictionary<string, SoundItem> Sound { get; set; }

        public void Save()
        {
            Save("data.json");
        }

        public bool IsAudioFile(string path) => Path.GetExtension(path).ToLower() == ".wav";
    }

    public class SoundItem
    {
        public string Filepath { get; set; }
        public string Filename { get; set; }
        public int Keybind { get; set; }
        public int Volume { get; set; }
    }
}