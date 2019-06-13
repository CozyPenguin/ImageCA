namespace ImageCA.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.StartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadStart = new System.Windows.Forms.ToolStripMenuItem();
            this.BildLadeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BildLaden = new System.Windows.Forms.ToolStripMenuItem();
            this.BildAufnehmen = new System.Windows.Forms.ToolStripMenuItem();
            this.Bearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.autoVorgang = new System.Windows.Forms.ToolStripMenuItem();
            this.FarbenWahlenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FW_EineFarbe = new System.Windows.Forms.ToolStripMenuItem();
            this.FW_mehrereFarbem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DatenLaden = new System.Windows.Forms.ToolStripMenuItem();
            this.DatenSpeichern = new System.Windows.Forms.ToolStripMenuItem();
            this.HilfeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EinstellungsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenImageTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cmd_ExtractColors = new System.Windows.Forms.Button();
            this.box_ColourExtraction = new System.Windows.Forms.GroupBox();
            this.nud_vColor = new System.Windows.Forms.NumericUpDown();
            this.nud_sColor = new System.Windows.Forms.NumericUpDown();
            this.nud_hColor = new System.Windows.Forms.NumericUpDown();
            this.nud_bColor = new System.Windows.Forms.NumericUpDown();
            this.nud_gColor = new System.Windows.Forms.NumericUpDown();
            this.nud_rColor = new System.Windows.Forms.NumericUpDown();
            this.lbl_bColor = new System.Windows.Forms.Label();
            this.lbl_gColor = new System.Windows.Forms.Label();
            this.lbl_rColor = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DebugLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveDataDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDisplay = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_hColor = new System.Windows.Forms.Label();
            this.lbl_sColor = new System.Windows.Forms.Label();
            this.lbl_vColor = new System.Windows.Forms.Label();
            this.cmd_ConvertColors = new System.Windows.Forms.Button();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.box_ColourExtraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rColor)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartMenu,
            this.BildLadeMenu,
            this.Bearbeiten,
            this.dataMenu,
            this.HilfeMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(715, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // StartMenu
            // 
            this.StartMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReloadStart});
            this.StartMenu.Name = "StartMenu";
            this.StartMenu.Size = new System.Drawing.Size(37, 20);
            this.StartMenu.Text = "File";
            // 
            // ReloadStart
            // 
            this.ReloadStart.Name = "ReloadStart";
            this.ReloadStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ReloadStart.Size = new System.Drawing.Size(180, 22);
            this.ReloadStart.Text = "Neu";
            this.ReloadStart.Click += new System.EventHandler(this.ReloadStart_Click);
            // 
            // BildLadeMenu
            // 
            this.BildLadeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BildLaden,
            this.toolStripMenuItem2,
            this.BildAufnehmen});
            this.BildLadeMenu.Name = "BildLadeMenu";
            this.BildLadeMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.BildLadeMenu.Size = new System.Drawing.Size(52, 20);
            this.BildLadeMenu.Text = "Image";
            // 
            // BildLaden
            // 
            this.BildLaden.Name = "BildLaden";
            this.BildLaden.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.BildLaden.Size = new System.Drawing.Size(233, 22);
            this.BildLaden.Text = "Bild öffnen";
            this.BildLaden.Click += new System.EventHandler(this.Load_Image);
            // 
            // BildAufnehmen
            // 
            this.BildAufnehmen.Enabled = false;
            this.BildAufnehmen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BildAufnehmen.Name = "BildAufnehmen";
            this.BildAufnehmen.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.BildAufnehmen.Size = new System.Drawing.Size(233, 22);
            this.BildAufnehmen.Text = "Bild aufnehmen";
            // 
            // Bearbeiten
            // 
            this.Bearbeiten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoVorgang,
            this.FarbenWahlenMenu});
            this.Bearbeiten.Name = "Bearbeiten";
            this.Bearbeiten.Size = new System.Drawing.Size(39, 20);
            this.Bearbeiten.Text = "Edit";
            // 
            // autoVorgang
            // 
            this.autoVorgang.Name = "autoVorgang";
            this.autoVorgang.Size = new System.Drawing.Size(201, 22);
            this.autoVorgang.Text = "automatisch extrahieren";
            this.autoVorgang.Click += new System.EventHandler(this.Cmd_ExtractColors_Click);
            // 
            // FarbenWahlenMenu
            // 
            this.FarbenWahlenMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FW_EineFarbe,
            this.FW_mehrereFarbem});
            this.FarbenWahlenMenu.Name = "FarbenWahlenMenu";
            this.FarbenWahlenMenu.Size = new System.Drawing.Size(201, 22);
            this.FarbenWahlenMenu.Text = "Farbe wählen";
            // 
            // FW_EineFarbe
            // 
            this.FW_EineFarbe.Name = "FW_EineFarbe";
            this.FW_EineFarbe.Size = new System.Drawing.Size(157, 22);
            this.FW_EineFarbe.Text = "eine Farbe";
            // 
            // FW_mehrereFarbem
            // 
            this.FW_mehrereFarbem.Name = "FW_mehrereFarbem";
            this.FW_mehrereFarbem.Size = new System.Drawing.Size(157, 22);
            this.FW_mehrereFarbem.Text = "mehrere Farben";
            // 
            // dataMenu
            // 
            this.dataMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatenLaden,
            this.DatenSpeichern});
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.Size = new System.Drawing.Size(43, 20);
            this.dataMenu.Text = "Data";
            // 
            // DatenLaden
            // 
            this.DatenLaden.Name = "DatenLaden";
            this.DatenLaden.Size = new System.Drawing.Size(180, 22);
            this.DatenLaden.Text = "Daten laden";
            // 
            // DatenSpeichern
            // 
            this.DatenSpeichern.Name = "DatenSpeichern";
            this.DatenSpeichern.Size = new System.Drawing.Size(180, 22);
            this.DatenSpeichern.Text = "Daten speichern";
            // 
            // HilfeMenu
            // 
            this.HilfeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.EinstellungsMenu});
            this.HilfeMenu.Name = "HilfeMenu";
            this.HilfeMenu.Size = new System.Drawing.Size(44, 20);
            this.HilfeMenu.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem1.Text = "Dokumentation";
            // 
            // EinstellungsMenu
            // 
            this.EinstellungsMenu.Name = "EinstellungsMenu";
            this.EinstellungsMenu.ShortcutKeyDisplayString = "";
            this.EinstellungsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EinstellungsMenu.Size = new System.Drawing.Size(186, 22);
            this.EinstellungsMenu.Text = "Einstellungen";
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imageBox.InitialImage = null;
            this.imageBox.Location = new System.Drawing.Point(361, 56);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(311, 253);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 9;
            this.imageBox.TabStop = false;
            this.imageBox.DoubleClick += new System.EventHandler(this.Load_Image);
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.FilterIndex = 2;
            this.OpenImageDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);";
            this.OpenImageDialog.Multiselect = true;
            // 
            // cmd_ExtractColors
            // 
            this.cmd_ExtractColors.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_ExtractColors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmd_ExtractColors.Location = new System.Drawing.Point(18, 32);
            this.cmd_ExtractColors.Name = "cmd_ExtractColors";
            this.cmd_ExtractColors.Size = new System.Drawing.Size(101, 34);
            this.cmd_ExtractColors.TabIndex = 4;
            this.cmd_ExtractColors.Text = "Extract colours";
            this.cmd_ExtractColors.UseVisualStyleBackColor = true;
            this.cmd_ExtractColors.Click += new System.EventHandler(this.Cmd_ExtractColors_Click);
            // 
            // box_ColourExtraction
            // 
            this.box_ColourExtraction.Controls.Add(this.cmd_ConvertColors);
            this.box_ColourExtraction.Controls.Add(this.lbl_vColor);
            this.box_ColourExtraction.Controls.Add(this.lbl_sColor);
            this.box_ColourExtraction.Controls.Add(this.lbl_hColor);
            this.box_ColourExtraction.Controls.Add(this.nud_vColor);
            this.box_ColourExtraction.Controls.Add(this.nud_sColor);
            this.box_ColourExtraction.Controls.Add(this.nud_hColor);
            this.box_ColourExtraction.Controls.Add(this.nud_bColor);
            this.box_ColourExtraction.Controls.Add(this.nud_gColor);
            this.box_ColourExtraction.Controls.Add(this.nud_rColor);
            this.box_ColourExtraction.Controls.Add(this.lbl_bColor);
            this.box_ColourExtraction.Controls.Add(this.lbl_gColor);
            this.box_ColourExtraction.Controls.Add(this.lbl_rColor);
            this.box_ColourExtraction.Controls.Add(this.textBox7);
            this.box_ColourExtraction.Controls.Add(this.textBox8);
            this.box_ColourExtraction.Controls.Add(this.textBox9);
            this.box_ColourExtraction.Controls.Add(this.cmd_ExtractColors);
            this.box_ColourExtraction.Location = new System.Drawing.Point(36, 56);
            this.box_ColourExtraction.Name = "box_ColourExtraction";
            this.box_ColourExtraction.Size = new System.Drawing.Size(252, 300);
            this.box_ColourExtraction.TabIndex = 6;
            this.box_ColourExtraction.TabStop = false;
            this.box_ColourExtraction.Text = "Extract colours";
            // 
            // nud_vColor
            // 
            this.nud_vColor.DecimalPlaces = 3;
            this.nud_vColor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_vColor.Location = new System.Drawing.Point(148, 155);
            this.nud_vColor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_vColor.Name = "nud_vColor";
            this.nud_vColor.Size = new System.Drawing.Size(59, 20);
            this.nud_vColor.TabIndex = 23;
            this.nud_vColor.ValueChanged += new System.EventHandler(this.Nud_vColor_ValueChanged);
            // 
            // nud_sColor
            // 
            this.nud_sColor.DecimalPlaces = 3;
            this.nud_sColor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_sColor.Location = new System.Drawing.Point(83, 155);
            this.nud_sColor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_sColor.Name = "nud_sColor";
            this.nud_sColor.Size = new System.Drawing.Size(59, 20);
            this.nud_sColor.TabIndex = 22;
            this.nud_sColor.ValueChanged += new System.EventHandler(this.Nud_sColor_ValueChanged);
            // 
            // nud_hColor
            // 
            this.nud_hColor.DecimalPlaces = 1;
            this.nud_hColor.Location = new System.Drawing.Point(18, 155);
            this.nud_hColor.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nud_hColor.Name = "nud_hColor";
            this.nud_hColor.Size = new System.Drawing.Size(59, 20);
            this.nud_hColor.TabIndex = 21;
            this.nud_hColor.ValueChanged += new System.EventHandler(this.Nud_hColor_ValueChanged);
            // 
            // nud_bColor
            // 
            this.nud_bColor.DecimalPlaces = 1;
            this.nud_bColor.Location = new System.Drawing.Point(148, 97);
            this.nud_bColor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_bColor.Name = "nud_bColor";
            this.nud_bColor.Size = new System.Drawing.Size(59, 20);
            this.nud_bColor.TabIndex = 20;
            this.nud_bColor.ValueChanged += new System.EventHandler(this.Nud_bColor_ValueChanged);
            // 
            // nud_gColor
            // 
            this.nud_gColor.DecimalPlaces = 1;
            this.nud_gColor.Location = new System.Drawing.Point(83, 97);
            this.nud_gColor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_gColor.Name = "nud_gColor";
            this.nud_gColor.Size = new System.Drawing.Size(59, 20);
            this.nud_gColor.TabIndex = 19;
            this.nud_gColor.ValueChanged += new System.EventHandler(this.Nud_gColor_ValueChanged);
            // 
            // nud_rColor
            // 
            this.nud_rColor.DecimalPlaces = 1;
            this.nud_rColor.Location = new System.Drawing.Point(18, 97);
            this.nud_rColor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_rColor.Name = "nud_rColor";
            this.nud_rColor.Size = new System.Drawing.Size(59, 20);
            this.nud_rColor.TabIndex = 18;
            this.nud_rColor.ValueChanged += new System.EventHandler(this.Nud_rColor_ValueChanged);
            // 
            // lbl_bColor
            // 
            this.lbl_bColor.AutoSize = true;
            this.lbl_bColor.Location = new System.Drawing.Point(148, 81);
            this.lbl_bColor.Name = "lbl_bColor";
            this.lbl_bColor.Size = new System.Drawing.Size(14, 13);
            this.lbl_bColor.TabIndex = 17;
            this.lbl_bColor.Text = "B";
            // 
            // lbl_gColor
            // 
            this.lbl_gColor.AutoSize = true;
            this.lbl_gColor.Location = new System.Drawing.Point(83, 81);
            this.lbl_gColor.Name = "lbl_gColor";
            this.lbl_gColor.Size = new System.Drawing.Size(15, 13);
            this.lbl_gColor.TabIndex = 16;
            this.lbl_gColor.Text = "G";
            // 
            // lbl_rColor
            // 
            this.lbl_rColor.AutoSize = true;
            this.lbl_rColor.Location = new System.Drawing.Point(15, 81);
            this.lbl_rColor.Name = "lbl_rColor";
            this.lbl_rColor.Size = new System.Drawing.Size(15, 13);
            this.lbl_rColor.TabIndex = 15;
            this.lbl_rColor.Text = "R";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(148, 212);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(59, 20);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(83, 212);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(59, 20);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(18, 212);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(59, 20);
            this.textBox9.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebugLog});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(715, 24);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DebugLog
            // 
            this.DebugLog.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.DebugLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DebugLog.DoubleClickEnabled = true;
            this.DebugLog.LinkVisited = true;
            this.DebugLog.Name = "DebugLog";
            this.DebugLog.Size = new System.Drawing.Size(66, 19);
            this.DebugLog.Text = "DebugLog";
            // 
            // SaveDataDialog
            // 
            this.SaveDataDialog.Filter = "Xml Dateien|*.xml";
            // 
            // colorDisplay
            // 
            this.colorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorDisplay.Location = new System.Drawing.Point(54, 362);
            this.colorDisplay.Name = "colorDisplay";
            this.colorDisplay.Size = new System.Drawing.Size(50, 50);
            this.colorDisplay.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl_hColor
            // 
            this.lbl_hColor.AutoSize = true;
            this.lbl_hColor.Location = new System.Drawing.Point(15, 139);
            this.lbl_hColor.Name = "lbl_hColor";
            this.lbl_hColor.Size = new System.Drawing.Size(15, 13);
            this.lbl_hColor.TabIndex = 24;
            this.lbl_hColor.Text = "H";
            // 
            // lbl_sColor
            // 
            this.lbl_sColor.AutoSize = true;
            this.lbl_sColor.Location = new System.Drawing.Point(83, 139);
            this.lbl_sColor.Name = "lbl_sColor";
            this.lbl_sColor.Size = new System.Drawing.Size(14, 13);
            this.lbl_sColor.TabIndex = 25;
            this.lbl_sColor.Text = "S";
            // 
            // lbl_vColor
            // 
            this.lbl_vColor.AutoSize = true;
            this.lbl_vColor.Location = new System.Drawing.Point(148, 139);
            this.lbl_vColor.Name = "lbl_vColor";
            this.lbl_vColor.Size = new System.Drawing.Size(14, 13);
            this.lbl_vColor.TabIndex = 26;
            this.lbl_vColor.Text = "V";
            // 
            // cmd_ConvertColors
            // 
            this.cmd_ConvertColors.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_ConvertColors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmd_ConvertColors.Location = new System.Drawing.Point(125, 32);
            this.cmd_ConvertColors.Name = "cmd_ConvertColors";
            this.cmd_ConvertColors.Size = new System.Drawing.Size(101, 34);
            this.cmd_ConvertColors.TabIndex = 27;
            this.cmd_ConvertColors.Text = "Convert colours";
            this.cmd_ConvertColors.UseVisualStyleBackColor = true;
            this.cmd_ConvertColors.Click += new System.EventHandler(this.Cmd_ConvertColors_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem2.Text = "Open photos";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(715, 497);
            this.Controls.Add(this.colorDisplay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.box_ColourExtraction);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.MainMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Image Colour Analysis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.box_ColourExtraction.ResumeLayout(false);
            this.box_ColourExtraction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rColor)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem StartMenu;
        private System.Windows.Forms.ToolStripMenuItem BildLadeMenu;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.ToolStripMenuItem BildLaden;
        private System.Windows.Forms.ToolStripMenuItem BildAufnehmen;
        private System.Windows.Forms.ToolStripMenuItem ReloadStart;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.ToolTip OpenImageTooltip;
        private System.Windows.Forms.Button cmd_ExtractColors;
        private System.Windows.Forms.ToolStripMenuItem HilfeMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EinstellungsMenu;
        private System.Windows.Forms.GroupBox box_ColourExtraction;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem Bearbeiten;
        private System.Windows.Forms.ToolStripMenuItem autoVorgang;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem FarbenWahlenMenu;
        private System.Windows.Forms.ToolStripMenuItem FW_EineFarbe;
        private System.Windows.Forms.ToolStripMenuItem FW_mehrereFarbem;
        private System.Windows.Forms.ToolStripMenuItem dataMenu;
        private System.Windows.Forms.ToolStripMenuItem DatenLaden;
        private System.Windows.Forms.ToolStripMenuItem DatenSpeichern;
        private System.Windows.Forms.SaveFileDialog SaveDataDialog;
        public System.Windows.Forms.ToolStripStatusLabel DebugLog;
        private System.Windows.Forms.Panel colorDisplay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lbl_bColor;
        private System.Windows.Forms.Label lbl_gColor;
        private System.Windows.Forms.Label lbl_rColor;
        private System.Windows.Forms.NumericUpDown nud_vColor;
        private System.Windows.Forms.NumericUpDown nud_sColor;
        private System.Windows.Forms.NumericUpDown nud_hColor;
        private System.Windows.Forms.NumericUpDown nud_bColor;
        private System.Windows.Forms.NumericUpDown nud_gColor;
        private System.Windows.Forms.NumericUpDown nud_rColor;
        private System.Windows.Forms.Label lbl_vColor;
        private System.Windows.Forms.Label lbl_sColor;
        private System.Windows.Forms.Label lbl_hColor;
        private System.Windows.Forms.Button cmd_ConvertColors;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}