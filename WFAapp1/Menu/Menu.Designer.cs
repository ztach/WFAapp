﻿namespace WFAapp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.bazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksiegarniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wprowadzOsobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WprowadzKsiazkeTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarzadzajWypozyczeniamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zestawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKsiazekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCzytelnikowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaWypozyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gdzieJestBazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WczytajInnaBazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnExitX = new System.Windows.Forms.Button();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.panelSubHelp = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.panelSubHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bazaToolStripMenuItem,
            this.zestawieniaToolStripMenuItem,
            this.fileMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu,
            this.adminToolStripMenuItem,
            this.toolStripComboBox1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // bazaToolStripMenuItem
            // 
            this.bazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ksiegarniaToolStripMenuItem,
            this.wprowadzOsobeToolStripMenuItem,
            this.WprowadzKsiazkeTSMenuItem,
            this.zarzadzajWypozyczeniamiToolStripMenuItem});
            this.bazaToolStripMenuItem.Name = "bazaToolStripMenuItem";
            this.bazaToolStripMenuItem.Size = new System.Drawing.Size(112, 28);
            this.bazaToolStripMenuItem.Text = "Formularze";
            this.bazaToolStripMenuItem.DropDownOpened += new System.EventHandler(this.bazaToolStripMenuItem_DropDownOpened);
            this.bazaToolStripMenuItem.MouseEnter += new System.EventHandler(this.bazaToolStripMenuItem_DropDownOpened);
            // 
            // ksiegarniaToolStripMenuItem
            // 
            this.ksiegarniaToolStripMenuItem.Name = "ksiegarniaToolStripMenuItem";
            this.ksiegarniaToolStripMenuItem.Size = new System.Drawing.Size(298, 28);
            this.ksiegarniaToolStripMenuItem.Text = "Ksiegarnia";
            this.ksiegarniaToolStripMenuItem.Click += new System.EventHandler(this.ksiegarniaToolStripMenuItem_Click);
            // 
            // wprowadzOsobeToolStripMenuItem
            // 
            this.wprowadzOsobeToolStripMenuItem.Name = "wprowadzOsobeToolStripMenuItem";
            this.wprowadzOsobeToolStripMenuItem.Size = new System.Drawing.Size(298, 28);
            this.wprowadzOsobeToolStripMenuItem.Text = "Wprowadź osobę";
            this.wprowadzOsobeToolStripMenuItem.Click += new System.EventHandler(this.wprowadzOsobeToolStripMenuItem_Click);
            // 
            // WprowadzKsiazkeTSMenuItem
            // 
            this.WprowadzKsiazkeTSMenuItem.Name = "WprowadzKsiazkeTSMenuItem";
            this.WprowadzKsiazkeTSMenuItem.Size = new System.Drawing.Size(298, 28);
            this.WprowadzKsiazkeTSMenuItem.Text = "Wprowadź książkę";
            this.WprowadzKsiazkeTSMenuItem.Click += new System.EventHandler(this.WprowadzKsiazkeTSMenuItem_Click);
            // 
            // zarzadzajWypozyczeniamiToolStripMenuItem
            // 
            this.zarzadzajWypozyczeniamiToolStripMenuItem.Name = "zarzadzajWypozyczeniamiToolStripMenuItem";
            this.zarzadzajWypozyczeniamiToolStripMenuItem.Size = new System.Drawing.Size(298, 28);
            this.zarzadzajWypozyczeniamiToolStripMenuItem.Text = "Zarządzaj wypożyczeniami";
            this.zarzadzajWypozyczeniamiToolStripMenuItem.Click += new System.EventHandler(this.zarzadzajWypozyczeniamiToolStripMenuItem_Click);
            // 
            // zestawieniaToolStripMenuItem
            // 
            this.zestawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaKsiazekToolStripMenuItem,
            this.listaCzytelnikowToolStripMenuItem,
            this.listaWypozyToolStripMenuItem});
            this.zestawieniaToolStripMenuItem.Name = "zestawieniaToolStripMenuItem";
            this.zestawieniaToolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.zestawieniaToolStripMenuItem.Text = "Zestawienia";
            this.zestawieniaToolStripMenuItem.MouseEnter += new System.EventHandler(this.bazaToolStripMenuItem_DropDownOpened);
            // 
            // listaKsiazekToolStripMenuItem
            // 
            this.listaKsiazekToolStripMenuItem.Name = "listaKsiazekToolStripMenuItem";
            this.listaKsiazekToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.listaKsiazekToolStripMenuItem.Text = "Lista ksiazek";
            this.listaKsiazekToolStripMenuItem.Click += new System.EventHandler(this.listaKsiazekToolStripMenuItem_Click);
            // 
            // listaCzytelnikowToolStripMenuItem
            // 
            this.listaCzytelnikowToolStripMenuItem.Name = "listaCzytelnikowToolStripMenuItem";
            this.listaCzytelnikowToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.listaCzytelnikowToolStripMenuItem.Text = "Lista czytelników";
            this.listaCzytelnikowToolStripMenuItem.Click += new System.EventHandler(this.listaCzytelnikowToolStripMenuItem_Click);
            // 
            // listaWypozyToolStripMenuItem
            // 
            this.listaWypozyToolStripMenuItem.Name = "listaWypozyToolStripMenuItem";
            this.listaWypozyToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.listaWypozyToolStripMenuItem.Text = "Lista wypożyczeń";
            this.listaWypozyToolStripMenuItem.Click += new System.EventHandler(this.listaWypozyToolStripMenuItem_Click);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(50, 28);
            this.fileMenu.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // printSetupToolStripMenuItem
            // 
            this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.printSetupToolStripMenuItem.Text = "Print Setup";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(64, 28);
            this.toolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(96, 28);
            this.windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.newWindowToolStripMenuItem.Text = "&New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem,
            this.gdzieJestBazaToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(60, 28);
            this.helpMenu.Text = "&Help";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(223, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.aboutToolStripMenuItem.Text = "&About Program...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gdzieJestBazaToolStripMenuItem
            // 
            this.gdzieJestBazaToolStripMenuItem.Name = "gdzieJestBazaToolStripMenuItem";
            this.gdzieJestBazaToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.gdzieJestBazaToolStripMenuItem.Text = "Gdzie jest baza";
            this.gdzieJestBazaToolStripMenuItem.Click += new System.EventHandler(this.gdzieJestBazaToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dostepToolStripMenuItem,
            this.WczytajInnaBazeToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(76, 28);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.DropDownOpened += new System.EventHandler(this.adminToolStripMenuItem_DropDownOpened);
            // 
            // dostepToolStripMenuItem
            // 
            this.dostepToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dostepToolStripMenuItem.Name = "dostepToolStripMenuItem";
            this.dostepToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.dostepToolStripMenuItem.Text = "Dostęp";
            this.dostepToolStripMenuItem.ToolTipText = "ustawia dostęp do bazy";
            this.dostepToolStripMenuItem.Click += new System.EventHandler(this.dostepToolStripMenuItem_Click);
            // 
            // WczytajInnaBazeToolStripMenuItem
            // 
            this.WczytajInnaBazeToolStripMenuItem.Name = "WczytajInnaBazeToolStripMenuItem";
            this.WczytajInnaBazeToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.WczytajInnaBazeToolStripMenuItem.Text = "Wczytaj inną bazę";
            this.WczytajInnaBazeToolStripMenuItem.Click += new System.EventHandler(this.WczytajInnaBazeToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Staszek",
            "Basia",
            "Admin"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // btnExitX
            // 
            this.btnExitX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExitX.ForeColor = System.Drawing.Color.White;
            this.btnExitX.Location = new System.Drawing.Point(743, 0);
            this.btnExitX.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitX.Name = "btnExitX";
            this.btnExitX.Padding = new System.Windows.Forms.Padding(2, 0, 0, 5);
            this.btnExitX.Size = new System.Drawing.Size(43, 43);
            this.btnExitX.TabIndex = 1;
            this.btnExitX.Text = "x";
            this.toolTip.SetToolTip(this.btnExitX, "ZAMKNIJ");
            this.btnExitX.UseVisualStyleBackColor = false;
            this.btnExitX.Click += new System.EventHandler(this.btnExitX_Click);
            // 
            // panelHelp
            // 
            this.panelHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHelp.BackColor = System.Drawing.Color.Gray;
            this.panelHelp.Controls.Add(this.btnExitX);
            this.panelHelp.Controls.Add(this.panelSubHelp);
            this.panelHelp.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.panelHelp.Location = new System.Drawing.Point(38, 43);
            this.panelHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(786, 322);
            this.panelHelp.TabIndex = 4;
            // 
            // panelSubHelp
            // 
            this.panelSubHelp.Controls.Add(this.listBox1);
            this.panelSubHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubHelp.Location = new System.Drawing.Point(0, 43);
            this.panelSubHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSubHelp.Name = "panelSubHelp";
            this.panelSubHelp.Size = new System.Drawing.Size(786, 279);
            this.panelSubHelp.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Dostęp do bazy odbywa się przez plik z rozrzerzeniem ini.",
            "Plik ten znajduje się w ktatalogu głównym programu i ma nazwę taką samą jak progr" +
                "am.",
            "",
            "Plik ini ma postać:",
            "[CONNECT]",
            "myConFile=Ksiazki.s3db",
            "myConPath=e:\\praca\\WFAapp\\WFAapp1\\Baza\\",
            "",
            "Zmienna: myConPath - posiada pełną ścieżkę do bazy.",
            "Zmienna: myConFile - zawiera nazwę bazy."});
            this.listBox1.Location = new System.Drawing.Point(3, 2);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(784, 224);
            this.listBox1.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MdiChildActivate += new System.EventHandler(this.Menu_MdiChildActivate);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelHelp.ResumeLayout(false);
            this.panelSubHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem bazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ksiegarniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gdzieJestBazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wprowadzOsobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WprowadzKsiazkeTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarzadzajWypozyczeniamiToolStripMenuItem;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Button btnExitX;
        private System.Windows.Forms.Panel panelSubHelp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem zestawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKsiazekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCzytelnikowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaWypozyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem dostepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WczytajInnaBazeToolStripMenuItem;
    }
}



