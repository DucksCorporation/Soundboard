namespace SoundBoard
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Sound1 = new System.Windows.Forms.Button();
            this.ButtonInfosContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirLeBindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLeSonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sound2 = new System.Windows.Forms.Button();
            this.Sound3 = new System.Windows.Forms.Button();
            this.Sound4 = new System.Windows.Forms.Button();
            this.Sound6 = new System.Windows.Forms.Button();
            this.Sound5 = new System.Windows.Forms.Button();
            this.SettingsMenu = new System.Windows.Forms.MenuStrip();
            this.OuvrirLeFichierDeSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accèdezAuCodeSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accédezAuxTutorielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sound8 = new System.Windows.Forms.Button();
            this.Sound7 = new System.Windows.Forms.Button();
            this.Sound12 = new System.Windows.Forms.Button();
            this.Sound9 = new System.Windows.Forms.Button();
            this.Sound10 = new System.Windows.Forms.Button();
            this.Sound11 = new System.Windows.Forms.Button();
            this.Sound15 = new System.Windows.Forms.Button();
            this.Sound13 = new System.Windows.Forms.Button();
            this.Sound14 = new System.Windows.Forms.Button();
            this.Sound16 = new System.Windows.Forms.Button();
            this.Sound18 = new System.Windows.Forms.Button();
            this.Sound17 = new System.Windows.Forms.Button();
            this.Sound20 = new System.Windows.Forms.Button();
            this.Sound19 = new System.Windows.Forms.Button();
            this.Sound21 = new System.Windows.Forms.Button();
            this.Sound22 = new System.Windows.Forms.Button();
            this.Sound23 = new System.Windows.Forms.Button();
            this.Sound24 = new System.Windows.Forms.Button();
            this.Sound27 = new System.Windows.Forms.Button();
            this.Sound25 = new System.Windows.Forms.Button();
            this.Sound26 = new System.Windows.Forms.Button();
            this.Sound32 = new System.Windows.Forms.Button();
            this.Sound30 = new System.Windows.Forms.Button();
            this.Sound29 = new System.Windows.Forms.Button();
            this.Sound28 = new System.Windows.Forms.Button();
            this.Sound31 = new System.Windows.Forms.Button();
            this.Sound35 = new System.Windows.Forms.Button();
            this.Sound34 = new System.Windows.Forms.Button();
            this.Sound33 = new System.Windows.Forms.Button();
            this.Sound36 = new System.Windows.Forms.Button();
            this.Sound39 = new System.Windows.Forms.Button();
            this.Sound37 = new System.Windows.Forms.Button();
            this.Sound38 = new System.Windows.Forms.Button();
            this.Sound42 = new System.Windows.Forms.Button();
            this.Sound41 = new System.Windows.Forms.Button();
            this.Sound40 = new System.Windows.Forms.Button();
            this.ButtonInfosContextMenu.SuspendLayout();
            this.SettingsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sound1
            // 
            this.Sound1.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound1, "Sound1");
            this.Sound1.Name = "Sound1";
            this.Sound1.UseVisualStyleBackColor = true;
            this.Sound1.Click += new System.EventHandler(this.Sound1_Click);
            this.Sound1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound1_MouseUp);
            // 
            // ButtonInfosContextMenu
            // 
            this.ButtonInfosContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirLeBindToolStripMenuItem,
            this.ouvrirLeSonToolStripMenuItem,
            this.ChangeSoundToolStripMenuItem});
            this.ButtonInfosContextMenu.Name = "ButtonInfosContextMenu";
            resources.ApplyResources(this.ButtonInfosContextMenu, "ButtonInfosContextMenu");
            this.ButtonInfosContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ButtonInfosContextMenu_Opening);
            // 
            // ouvrirLeBindToolStripMenuItem
            // 
            this.ouvrirLeBindToolStripMenuItem.Name = "ouvrirLeBindToolStripMenuItem";
            resources.ApplyResources(this.ouvrirLeBindToolStripMenuItem, "ouvrirLeBindToolStripMenuItem");
            // 
            // ouvrirLeSonToolStripMenuItem
            // 
            this.ouvrirLeSonToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ouvrirLeSonToolStripMenuItem.Name = "ouvrirLeSonToolStripMenuItem";
            resources.ApplyResources(this.ouvrirLeSonToolStripMenuItem, "ouvrirLeSonToolStripMenuItem");
            this.ouvrirLeSonToolStripMenuItem.Click += new System.EventHandler(this.OpenSongToolStripMenuItem_Click);
            // 
            // ChangeSoundToolStripMenuItem
            // 
            this.ChangeSoundToolStripMenuItem.Name = "ChangeSoundToolStripMenuItem";
            resources.ApplyResources(this.ChangeSoundToolStripMenuItem, "ChangeSoundToolStripMenuItem");
            this.ChangeSoundToolStripMenuItem.Click += new System.EventHandler(this.ChangeSoundToolStripMenuItem_Click);
            // 
            // Sound2
            // 
            this.Sound2.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound2, "Sound2");
            this.Sound2.Name = "Sound2";
            this.Sound2.UseVisualStyleBackColor = true;
            this.Sound2.Click += new System.EventHandler(this.Sound2_Click);
            this.Sound2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound2_MouseUp);
            // 
            // Sound3
            // 
            this.Sound3.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound3, "Sound3");
            this.Sound3.Name = "Sound3";
            this.Sound3.UseVisualStyleBackColor = true;
            this.Sound3.Click += new System.EventHandler(this.Sound3_Click);
            this.Sound3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound3_MouseUp);
            // 
            // Sound4
            // 
            this.Sound4.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound4, "Sound4");
            this.Sound4.Name = "Sound4";
            this.Sound4.UseVisualStyleBackColor = true;
            this.Sound4.Click += new System.EventHandler(this.Sound4_Click);
            this.Sound4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound4_MouseUp);
            // 
            // Sound6
            // 
            this.Sound6.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound6, "Sound6");
            this.Sound6.Name = "Sound6";
            this.Sound6.UseVisualStyleBackColor = true;
            this.Sound6.Click += new System.EventHandler(this.Sound6_Click);
            this.Sound6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound6_MouseUp);
            // 
            // Sound5
            // 
            this.Sound5.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound5, "Sound5");
            this.Sound5.Name = "Sound5";
            this.Sound5.UseVisualStyleBackColor = true;
            this.Sound5.Click += new System.EventHandler(this.Sound5_Click);
            this.Sound5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound5_MouseUp);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.SettingsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OuvrirLeFichierDeSauvegardeToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            resources.ApplyResources(this.SettingsMenu, "SettingsMenu");
            this.SettingsMenu.Name = "SettingsMenu";
            // 
            // OuvrirLeFichierDeSauvegardeToolStripMenuItem
            // 
            this.OuvrirLeFichierDeSauvegardeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(200, 0, 50, 0);
            this.OuvrirLeFichierDeSauvegardeToolStripMenuItem.Name = "OuvrirLeFichierDeSauvegardeToolStripMenuItem";
            resources.ApplyResources(this.OuvrirLeFichierDeSauvegardeToolStripMenuItem, "OuvrirLeFichierDeSauvegardeToolStripMenuItem");
            this.OuvrirLeFichierDeSauvegardeToolStripMenuItem.Click += new System.EventHandler(this.OuvrirLeFichierDeSauvegardeToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accèdezAuCodeSourceToolStripMenuItem,
            this.accédezAuxTutorielsToolStripMenuItem,
            this.supportDiscordToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            resources.ApplyResources(this.SettingsToolStripMenuItem, "SettingsToolStripMenuItem");
            // 
            // accèdezAuCodeSourceToolStripMenuItem
            // 
            this.accèdezAuCodeSourceToolStripMenuItem.Name = "accèdezAuCodeSourceToolStripMenuItem";
            resources.ApplyResources(this.accèdezAuCodeSourceToolStripMenuItem, "accèdezAuCodeSourceToolStripMenuItem");
            this.accèdezAuCodeSourceToolStripMenuItem.Click += new System.EventHandler(this.OpenSourceCodeToolStripMenuItem_Click);
            // 
            // accédezAuxTutorielsToolStripMenuItem
            // 
            this.accédezAuxTutorielsToolStripMenuItem.Name = "accédezAuxTutorielsToolStripMenuItem";
            resources.ApplyResources(this.accédezAuxTutorielsToolStripMenuItem, "accédezAuxTutorielsToolStripMenuItem");
            this.accédezAuxTutorielsToolStripMenuItem.Click += new System.EventHandler(this.OpenTutorielsToolStripMenuItem_Click);
            // 
            // supportDiscordToolStripMenuItem
            // 
            this.supportDiscordToolStripMenuItem.Name = "supportDiscordToolStripMenuItem";
            resources.ApplyResources(this.supportDiscordToolStripMenuItem, "supportDiscordToolStripMenuItem");
            this.supportDiscordToolStripMenuItem.Click += new System.EventHandler(this.OpenDiscordSupportToolStripMenuItem_Click);
            // 
            // Sound8
            // 
            this.Sound8.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound8, "Sound8");
            this.Sound8.Name = "Sound8";
            this.Sound8.UseVisualStyleBackColor = true;
            this.Sound8.Click += new System.EventHandler(this.Sound8_Click);
            this.Sound8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound8_MouseUp);
            // 
            // Sound7
            // 
            this.Sound7.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound7, "Sound7");
            this.Sound7.Name = "Sound7";
            this.Sound7.UseVisualStyleBackColor = true;
            this.Sound7.Click += new System.EventHandler(this.Sound7_Click);
            this.Sound7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound7_MouseUp);
            // 
            // Sound12
            // 
            this.Sound12.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound12, "Sound12");
            this.Sound12.Name = "Sound12";
            this.Sound12.UseVisualStyleBackColor = true;
            this.Sound12.Click += new System.EventHandler(this.Sound12_Click);
            this.Sound12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound12_MouseUp);
            // 
            // Sound9
            // 
            this.Sound9.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound9, "Sound9");
            this.Sound9.Name = "Sound9";
            this.Sound9.UseVisualStyleBackColor = true;
            this.Sound9.Click += new System.EventHandler(this.Sound9_Click);
            this.Sound9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound9_MouseUp);
            // 
            // Sound10
            // 
            this.Sound10.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound10, "Sound10");
            this.Sound10.Name = "Sound10";
            this.Sound10.UseVisualStyleBackColor = true;
            this.Sound10.Click += new System.EventHandler(this.Sound10_Click);
            this.Sound10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound10_MouseUp);
            // 
            // Sound11
            // 
            this.Sound11.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound11, "Sound11");
            this.Sound11.Name = "Sound11";
            this.Sound11.UseVisualStyleBackColor = true;
            this.Sound11.Click += new System.EventHandler(this.Sound11_Click);
            this.Sound11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound11_MouseUp);
            // 
            // Sound15
            // 
            this.Sound15.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound15, "Sound15");
            this.Sound15.Name = "Sound15";
            this.Sound15.UseVisualStyleBackColor = true;
            this.Sound15.Click += new System.EventHandler(this.Sound15_Click);
            this.Sound15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound15_MouseUp);
            // 
            // Sound13
            // 
            this.Sound13.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound13, "Sound13");
            this.Sound13.Name = "Sound13";
            this.Sound13.UseVisualStyleBackColor = true;
            this.Sound13.Click += new System.EventHandler(this.Sound13_Click);
            this.Sound13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound13_MouseUp);
            // 
            // Sound14
            // 
            this.Sound14.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound14, "Sound14");
            this.Sound14.Name = "Sound14";
            this.Sound14.UseVisualStyleBackColor = true;
            this.Sound14.Click += new System.EventHandler(this.Sound14_Click);
            this.Sound14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound14_MouseUp);
            // 
            // Sound16
            // 
            this.Sound16.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound16, "Sound16");
            this.Sound16.Name = "Sound16";
            this.Sound16.UseVisualStyleBackColor = true;
            this.Sound16.Click += new System.EventHandler(this.Sound16_Click);
            this.Sound16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound16_MouseUp);
            // 
            // Sound18
            // 
            this.Sound18.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound18, "Sound18");
            this.Sound18.Name = "Sound18";
            this.Sound18.UseVisualStyleBackColor = true;
            this.Sound18.Click += new System.EventHandler(this.Sound18_Click);
            this.Sound18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound18_MouseUp);
            // 
            // Sound17
            // 
            this.Sound17.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound17, "Sound17");
            this.Sound17.Name = "Sound17";
            this.Sound17.UseVisualStyleBackColor = true;
            this.Sound17.Click += new System.EventHandler(this.Sound17_Click);
            this.Sound17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound17_MouseUp);
            // 
            // Sound20
            // 
            this.Sound20.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound20, "Sound20");
            this.Sound20.Name = "Sound20";
            this.Sound20.UseVisualStyleBackColor = true;
            this.Sound20.Click += new System.EventHandler(this.Sound20_Click);
            this.Sound20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound20_MouseUp);
            // 
            // Sound19
            // 
            this.Sound19.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound19, "Sound19");
            this.Sound19.Name = "Sound19";
            this.Sound19.UseVisualStyleBackColor = true;
            this.Sound19.Click += new System.EventHandler(this.Sound19_Click);
            this.Sound19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound19_MouseUp);
            // 
            // Sound21
            // 
            this.Sound21.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound21, "Sound21");
            this.Sound21.Name = "Sound21";
            this.Sound21.UseVisualStyleBackColor = true;
            this.Sound21.Click += new System.EventHandler(this.Sound21_Click);
            this.Sound21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound21_MouseUp);
            // 
            // Sound22
            // 
            this.Sound22.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound22, "Sound22");
            this.Sound22.Name = "Sound22";
            this.Sound22.UseVisualStyleBackColor = true;
            this.Sound22.Click += new System.EventHandler(this.Sound22_Click);
            this.Sound22.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound22_MouseUp);
            // 
            // Sound23
            // 
            this.Sound23.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound23, "Sound23");
            this.Sound23.Name = "Sound23";
            this.Sound23.UseVisualStyleBackColor = true;
            this.Sound23.Click += new System.EventHandler(this.Sound23_Click);
            this.Sound23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound23_MouseUp);
            // 
            // Sound24
            // 
            this.Sound24.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound24, "Sound24");
            this.Sound24.Name = "Sound24";
            this.Sound24.UseVisualStyleBackColor = true;
            this.Sound24.Click += new System.EventHandler(this.Sound24_Click);
            this.Sound24.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound24_MouseUp);
            // 
            // Sound27
            // 
            this.Sound27.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound27, "Sound27");
            this.Sound27.Name = "Sound27";
            this.Sound27.UseVisualStyleBackColor = true;
            this.Sound27.Click += new System.EventHandler(this.Sound27_Click);
            this.Sound27.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound27_MouseUp);
            // 
            // Sound25
            // 
            this.Sound25.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound25, "Sound25");
            this.Sound25.Name = "Sound25";
            this.Sound25.UseVisualStyleBackColor = true;
            this.Sound25.Click += new System.EventHandler(this.Sound25_Click);
            this.Sound25.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound25_MouseUp);
            // 
            // Sound26
            // 
            this.Sound26.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound26, "Sound26");
            this.Sound26.Name = "Sound26";
            this.Sound26.UseVisualStyleBackColor = true;
            this.Sound26.Click += new System.EventHandler(this.Sound26_Click);
            this.Sound26.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound26_MouseUp);
            // 
            // Sound32
            // 
            this.Sound32.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound32, "Sound32");
            this.Sound32.Name = "Sound32";
            this.Sound32.UseVisualStyleBackColor = true;
            this.Sound32.Click += new System.EventHandler(this.Sound32_Click);
            this.Sound32.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound32_MouseUp);
            // 
            // Sound30
            // 
            this.Sound30.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound30, "Sound30");
            this.Sound30.Name = "Sound30";
            this.Sound30.UseVisualStyleBackColor = true;
            this.Sound30.Click += new System.EventHandler(this.Sound30_Click);
            this.Sound30.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound30_MouseUp);
            // 
            // Sound29
            // 
            this.Sound29.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound29, "Sound29");
            this.Sound29.Name = "Sound29";
            this.Sound29.UseVisualStyleBackColor = true;
            this.Sound29.Click += new System.EventHandler(this.Sound29_Click);
            this.Sound29.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound29_MouseUp);
            // 
            // Sound28
            // 
            this.Sound28.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound28, "Sound28");
            this.Sound28.Name = "Sound28";
            this.Sound28.UseVisualStyleBackColor = true;
            this.Sound28.Click += new System.EventHandler(this.Sound28_Click);
            this.Sound28.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound28_MouseUp);
            // 
            // Sound31
            // 
            this.Sound31.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound31, "Sound31");
            this.Sound31.Name = "Sound31";
            this.Sound31.UseVisualStyleBackColor = true;
            this.Sound31.Click += new System.EventHandler(this.Sound31_Click);
            this.Sound31.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound31_MouseUp);
            // 
            // Sound35
            // 
            this.Sound35.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound35, "Sound35");
            this.Sound35.Name = "Sound35";
            this.Sound35.UseVisualStyleBackColor = true;
            this.Sound35.Click += new System.EventHandler(this.Sound35_Click);
            this.Sound35.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound35_MouseUp);
            // 
            // Sound34
            // 
            this.Sound34.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound34, "Sound34");
            this.Sound34.Name = "Sound34";
            this.Sound34.UseVisualStyleBackColor = true;
            this.Sound34.Click += new System.EventHandler(this.Sound34_Click);
            this.Sound34.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound34_MouseUp);
            // 
            // Sound33
            // 
            this.Sound33.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound33, "Sound33");
            this.Sound33.Name = "Sound33";
            this.Sound33.UseVisualStyleBackColor = true;
            this.Sound33.Click += new System.EventHandler(this.Sound33_Click);
            this.Sound33.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound33_MouseUp);
            // 
            // Sound36
            // 
            this.Sound36.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound36, "Sound36");
            this.Sound36.Name = "Sound36";
            this.Sound36.UseVisualStyleBackColor = true;
            this.Sound36.Click += new System.EventHandler(this.Sound36_Click);
            this.Sound36.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound36_MouseUp);
            // 
            // Sound39
            // 
            this.Sound39.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound39, "Sound39");
            this.Sound39.Name = "Sound39";
            this.Sound39.UseVisualStyleBackColor = true;
            this.Sound39.Click += new System.EventHandler(this.Sound39_Click);
            this.Sound39.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound39_MouseUp);
            // 
            // Sound37
            // 
            this.Sound37.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound37, "Sound37");
            this.Sound37.Name = "Sound37";
            this.Sound37.UseVisualStyleBackColor = true;
            this.Sound37.Click += new System.EventHandler(this.Sound37_Click);
            this.Sound37.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound37_MouseUp);
            // 
            // Sound38
            // 
            this.Sound38.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound38, "Sound38");
            this.Sound38.Name = "Sound38";
            this.Sound38.UseVisualStyleBackColor = true;
            this.Sound38.Click += new System.EventHandler(this.Sound38_Click);
            this.Sound38.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound38_MouseUp);
            // 
            // Sound42
            // 
            this.Sound42.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound42, "Sound42");
            this.Sound42.Name = "Sound42";
            this.Sound42.UseVisualStyleBackColor = true;
            this.Sound42.Click += new System.EventHandler(this.Sound42_Click);
            this.Sound42.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound42_MouseUp);
            // 
            // Sound41
            // 
            this.Sound41.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound41, "Sound41");
            this.Sound41.Name = "Sound41";
            this.Sound41.UseVisualStyleBackColor = true;
            this.Sound41.Click += new System.EventHandler(this.Sound41_Click);
            this.Sound41.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound41_MouseUp);
            // 
            // Sound40
            // 
            this.Sound40.ContextMenuStrip = this.ButtonInfosContextMenu;
            resources.ApplyResources(this.Sound40, "Sound40");
            this.Sound40.Name = "Sound40";
            this.Sound40.UseVisualStyleBackColor = true;
            this.Sound40.Click += new System.EventHandler(this.Sound40_Click);
            this.Sound40.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sound40_MouseUp);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Sound40);
            this.Controls.Add(this.Sound41);
            this.Controls.Add(this.Sound42);
            this.Controls.Add(this.Sound38);
            this.Controls.Add(this.Sound37);
            this.Controls.Add(this.Sound39);
            this.Controls.Add(this.Sound36);
            this.Controls.Add(this.Sound33);
            this.Controls.Add(this.Sound34);
            this.Controls.Add(this.Sound35);
            this.Controls.Add(this.Sound31);
            this.Controls.Add(this.Sound28);
            this.Controls.Add(this.Sound29);
            this.Controls.Add(this.Sound30);
            this.Controls.Add(this.Sound32);
            this.Controls.Add(this.Sound26);
            this.Controls.Add(this.Sound25);
            this.Controls.Add(this.Sound27);
            this.Controls.Add(this.Sound24);
            this.Controls.Add(this.Sound23);
            this.Controls.Add(this.Sound22);
            this.Controls.Add(this.Sound21);
            this.Controls.Add(this.Sound19);
            this.Controls.Add(this.Sound20);
            this.Controls.Add(this.Sound17);
            this.Controls.Add(this.Sound18);
            this.Controls.Add(this.Sound16);
            this.Controls.Add(this.Sound14);
            this.Controls.Add(this.Sound13);
            this.Controls.Add(this.Sound15);
            this.Controls.Add(this.Sound11);
            this.Controls.Add(this.Sound10);
            this.Controls.Add(this.Sound9);
            this.Controls.Add(this.Sound12);
            this.Controls.Add(this.Sound7);
            this.Controls.Add(this.Sound8);
            this.Controls.Add(this.SettingsMenu);
            this.Controls.Add(this.Sound5);
            this.Controls.Add(this.Sound6);
            this.Controls.Add(this.Sound4);
            this.Controls.Add(this.Sound3);
            this.Controls.Add(this.Sound2);
            this.Controls.Add(this.Sound1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.SettingsMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ButtonInfosContextMenu.ResumeLayout(false);
            this.SettingsMenu.ResumeLayout(false);
            this.SettingsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sound1;
        private System.Windows.Forms.Button Sound2;
        private System.Windows.Forms.Button Sound3;
        private System.Windows.Forms.Button Sound4;
        private System.Windows.Forms.Button Sound6;
        private System.Windows.Forms.Button Sound5;
        private System.Windows.Forms.ContextMenuStrip ButtonInfosContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLeBindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLeSonToolStripMenuItem;
        private System.Windows.Forms.MenuStrip SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem OuvrirLeFichierDeSauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeSoundToolStripMenuItem;
        private System.Windows.Forms.Button Sound7;
        private System.Windows.Forms.Button Sound8;
        private System.Windows.Forms.Button Sound10;
        private System.Windows.Forms.Button Sound12;
        private System.Windows.Forms.Button Sound9;
        private System.Windows.Forms.Button Sound11;
        private System.Windows.Forms.Button Sound15;
        private System.Windows.Forms.Button Sound13;
        private System.Windows.Forms.Button Sound14;
        private System.Windows.Forms.Button Sound16;
        private System.Windows.Forms.Button Sound18;
        private System.Windows.Forms.Button Sound17;
        private System.Windows.Forms.Button Sound20;
        private System.Windows.Forms.Button Sound19;
        private System.Windows.Forms.Button Sound21;
        private System.Windows.Forms.Button Sound22;
        private System.Windows.Forms.Button Sound23;
        private System.Windows.Forms.Button Sound24;
        private System.Windows.Forms.Button Sound27;
        private System.Windows.Forms.Button Sound25;
        private System.Windows.Forms.Button Sound26;
        private System.Windows.Forms.Button Sound32;
        private System.Windows.Forms.Button Sound30;
        private System.Windows.Forms.Button Sound29;
        private System.Windows.Forms.Button Sound28;
        private System.Windows.Forms.Button Sound31;
        private System.Windows.Forms.Button Sound35;
        private System.Windows.Forms.Button Sound34;
        private System.Windows.Forms.Button Sound33;
        private System.Windows.Forms.Button Sound36;
        private System.Windows.Forms.Button Sound39;
        private System.Windows.Forms.Button Sound37;
        private System.Windows.Forms.Button Sound38;
        private System.Windows.Forms.Button Sound42;
        private System.Windows.Forms.Button Sound41;
        private System.Windows.Forms.Button Sound40;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accèdezAuCodeSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accédezAuxTutorielsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportDiscordToolStripMenuItem;
    }
}

