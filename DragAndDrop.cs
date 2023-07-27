using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SoundBoard
{
    public partial class DragAndDrop : Form
    {
        public Button Button { get; set; }
        private readonly Sounds sounds;

        public DragAndDrop()
        {
            InitializeComponent();

            sounds = Data.Load("data.json");
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (!IsAudioFile(files[0]))
                {
                    MessageBox.Show("Seul les fichiers .wav sont acceptés !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                MessageBox.Show("Veuillez glissez des fichiers audios !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (!IsAudioFile(files[0]))
            {
                MessageBox.Show("Seul les fichiers .wav sont acceptés !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Êtes-vous sûr de vouloir ajouter le son : {files[0]} pour ce bouton ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                var filename = Path.GetFileNameWithoutExtension(files[0]);
                var filepath = Path.GetFullPath(files[0]);
                int keybind = int.MaxValue;

                if(sounds.Sound is null) sounds.Sound = new Dictionary<string, SoundItem>();

                if (!sounds.Sound.ContainsKey(Button.Name))
                {
                    sounds.Sound.Add(Button.Name, new SoundItem()
                    {
                        Filename = filename,
                        Filepath = filepath,
                        Keybind = keybind
                    });
                    sounds.Save();
                }

                Button.Text = filename;

                Close();
            }
            else
            {
                Close();
                new DragAndDrop();
            }
        }

        private bool IsAudioFile(string path) => Path.GetExtension(path).ToLower() == ".wav";
    }
}