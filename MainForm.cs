using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;
using System.Diagnostics;

namespace SoundBoard
{
    public partial class MainForm : Form
    {
        private readonly Sounds sounds;
        private readonly DragAndDrop dragAndDrop = new DragAndDrop();
        private readonly MediaPlayer mediaPlayer = new MediaPlayer();

        public MainForm()
        {
            InitializeComponent();

            sounds = Data.Load("data.json");

            foreach (Control control in Controls)
            {
                if (control is Button btn)
                {
                    //btn.Text = sounds.Sound[btn.Name].Filename;
                }
            }
        }

        #region events de mort
        private void Sound1_Click(object sender, EventArgs e) => Idk(Sound1);
        private void Sound2_Click(object sender, EventArgs e) => Idk(Sound2);
        private void Sound3_Click(object sender, EventArgs e) => Idk(Sound3);
        private void Sound4_Click(object sender, EventArgs e) => Idk(Sound4);
        private void Sound5_Click(object sender, EventArgs e) => Idk(Sound5);
        private void Sound6_Click(object sender, EventArgs e) => Idk(Sound6);

        private void Sound7_Click(object sender, EventArgs e) => Idk(Sound7);
        private void Sound8_Click(object sender, EventArgs e) => Idk(Sound8);
        private void Sound9_Click(object sender, EventArgs e) => Idk(Sound9);
        private void Sound10_Click(object sender, EventArgs e) => Idk(Sound10);
        private void Sound11_Click(object sender, EventArgs e) => Idk(Sound11);
        private void Sound12_Click(object sender, EventArgs e) => Idk(Sound12);

        private void Sound13_Click(object sender, EventArgs e) => Idk(Sound13);
        private void Sound14_Click(object sender, EventArgs e) => Idk(Sound14);
        private void Sound15_Click(object sender, EventArgs e) => Idk(Sound15);
        private void Sound16_Click(object sender, EventArgs e) => Idk(Sound16);
        private void Sound17_Click(object sender, EventArgs e) => Idk(Sound17);
        private void Sound18_Click(object sender, EventArgs e) => Idk(Sound18);

        private void Sound19_Click(object sender, EventArgs e) => Idk(Sound19);
        private void Sound20_Click(object sender, EventArgs e) => Idk(Sound20);
        private void Sound21_Click(object sender, EventArgs e) => Idk(Sound21);
        private void Sound22_Click(object sender, EventArgs e) => Idk(Sound22);
        private void Sound23_Click(object sender, EventArgs e) => Idk(Sound23);
        private void Sound24_Click(object sender, EventArgs e) => Idk(Sound24);

        private void Sound25_Click(object sender, EventArgs e) => Idk(Sound25);
        private void Sound26_Click(object sender, EventArgs e) => Idk(Sound26);
        private void Sound27_Click(object sender, EventArgs e) => Idk(Sound27);
        private void Sound28_Click(object sender, EventArgs e) => Idk(Sound28);
        private void Sound29_Click(object sender, EventArgs e) => Idk(Sound29);
        private void Sound30_Click(object sender, EventArgs e) => Idk(Sound30);

        private void Sound31_Click(object sender, EventArgs e) => Idk(Sound31);
        private void Sound32_Click(object sender, EventArgs e) => Idk(Sound32);
        private void Sound33_Click(object sender, EventArgs e) => Idk(Sound33);
        private void Sound34_Click(object sender, EventArgs e) => Idk(Sound34);
        private void Sound35_Click(object sender, EventArgs e) => Idk(Sound35);
        private void Sound36_Click(object sender, EventArgs e) => Idk(Sound36);

        private void Sound37_Click(object sender, EventArgs e) => Idk(Sound37);
        private void Sound38_Click(object sender, EventArgs e) => Idk(Sound38);
        private void Sound39_Click(object sender, EventArgs e) => Idk(Sound39);
        private void Sound40_Click(object sender, EventArgs e) => Idk(Sound40);
        private void Sound41_Click(object sender, EventArgs e) => Idk(Sound41);
        private void Sound42_Click(object sender, EventArgs e) => Idk(Sound42);


        private void Sound1_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound1, e);
        private void Sound2_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound2, e);
        private void Sound3_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound3, e);
        private void Sound4_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound4, e);
        private void Sound5_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound5, e);
        private void Sound6_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound6, e);

        private void Sound7_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound7, e);
        private void Sound8_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound8, e);
        private void Sound9_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound9, e);
        private void Sound10_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound10, e);
        private void Sound11_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound11, e);
        private void Sound12_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound12, e);

        private void Sound13_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound13, e);
        private void Sound14_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound14, e);
        private void Sound15_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound15, e);
        private void Sound16_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound16, e);
        private void Sound17_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound17, e);
        private void Sound18_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound18, e);

        private void Sound19_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound19, e);
        private void Sound20_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound20, e);
        private void Sound21_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound21, e);
        private void Sound22_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound22, e);
        private void Sound23_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound23, e);
        private void Sound24_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound24, e);

        private void Sound25_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound25, e);
        private void Sound26_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound26, e);
        private void Sound27_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound27, e);
        private void Sound28_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound28, e);
        private void Sound29_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound29, e);
        private void Sound30_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound30, e);

        private void Sound31_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound31, e);
        private void Sound32_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound32, e);
        private void Sound33_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound33, e);
        private void Sound34_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound34, e);
        private void Sound35_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound35, e);
        private void Sound36_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound36, e);

        private void Sound37_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound37, e);
        private void Sound38_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound38, e);
        private void Sound39_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound39, e);
        private void Sound40_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound40, e);
        private void Sound41_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound41, e);
        private void Sound42_MouseUp(object sender, MouseEventArgs e) => ShowIdk(Sound42, e);
        #endregion

        private void OuvrirLeFichierDeSauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Ducks_Corporation/SoundBoard/";

            try
            {
                if (!Directory.Exists(savePath))
                {
                    MessageBox.Show("Le dossier de sauvegarde est introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(savePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void OpenSongToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start(sounds.Sound[ButtonInfosContextMenu.SourceControl.Name].Filepath);

        internal void ShowIdk(Button button, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ButtonInfosContextMenu.Show(button, e.Location);
            }     
        }

        internal void Idk(Button button)
        {
            if (button.Text == "Vide")
            {
                dragAndDrop.Button = button;

                dragAndDrop.ShowDialog();
            }
            else
            {
                string path = sounds.Sound[button.Name].Filepath;

                if (!File.Exists(path))
                {
                    MessageBox.Show("Ce fichier son n'existe pas !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    return;
                }

                if (!sounds.IsAudioFile(path))
                {
                    MessageBox.Show("Le son doit être au format .wav!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    return;
                }

                try
                {
                    mediaPlayer.Volume = 0.1f;
                    mediaPlayer.Open(new Uri(path));
                    mediaPlayer.Play();
                }
                catch
                {
                    MessageBox.Show("Une erreur est apparu lors de la lecture du son !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                }
            }
        }

        private void ChangeSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dragAndDrop.Button = (Button)ButtonInfosContextMenu.SourceControl;

            dragAndDrop.ShowDialog();
        }

        private void ButtonInfosContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (!sounds.Sound.ContainsKey(ButtonInfosContextMenu.SourceControl.Name))
            //{
              //  ouvrirLeBindToolStripMenuItem.Enabled = false;
                //ouvrirLeSonToolStripMenuItem.Enabled = false;
            //}
        }

        private void OpenSourceCodeToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("idk");

        private void OpenTutorielsToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("tuto");

        private void OpenDiscordSupportToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("https://discord.gg/E5hPRnMUgq");
    }
}