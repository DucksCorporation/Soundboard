using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SoundBoard
{
    public class Data
    {
        public static string GetFilePath(string path) => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Ducks_Corporation/SoundBoard/" + path;

        public void Save(string path)
        {
            File.WriteAllText(GetFilePath(path), JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented }));
        }

        public static Sounds Load(string path)
        {
            string filePath = GetFilePath(path);
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Le fichier de sauvegarde n'existe pas ! \n Tentative de création...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Sounds();
            }

            string data = File.ReadAllText(filePath);
            try
            {
                JsonConvert.DeserializeObject<Sounds>(data);
                return new Sounds();
            }
            catch
            {
                MessageBox.Show("Le fichier parvenu n'a pas pu être parsé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Sounds();
            }
        }
    }
}